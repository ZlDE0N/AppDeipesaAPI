using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppDeipesaAPI.Models;

namespace AppDeipesaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialesController : ControllerBase
    {
        private readonly InventarioDeipesaContext _context;

        public MaterialesController(InventarioDeipesaContext context)
        {
            _context = context;
        }

        [HttpGet("with-order-details")]
        public async Task<ActionResult<List<Materiale>>> GetMaterialesWithOrderDetails()
        {
            return Ok(await _context.Materiales
                .Include(m => m.DetalleOrdenCompras)
                .ToListAsync());
        }

        // GET: api/Materiales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Materiale>>> GetMateriales()
        {
            if (_context.Materiales == null)
            {
                return NotFound();
            }
            return await _context.Materiales.ToListAsync();
        }

        // GET: api/Materiales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Materiale>> GetMateriale(string id)
        {
            if (_context.Materiales == null)
            {
                return NotFound();
            }
            var materiale = await _context.Materiales.FindAsync(id);

            if (materiale == null)
            {
                return NotFound();
            }

            return materiale;
        }

        // PUT: api/Materiales/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMateriale(string id, Materiale materiale)
        {
            if (id != materiale.IdMaterial)
            {
                return BadRequest();
            }

            _context.Entry(materiale).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MaterialeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Materiales
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Materiale>> PostMateriale(Materiale materiale)
        {
            if (IsDuplicated(materiale))
            {
                return Conflict();
            }

            if (_context.Materiales == null)
            {
                return Problem("Entity set 'InventarioDeipesaContext.Materiales'  is null.");
            }
            _context.Materiales.Add(materiale);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MaterialeExists(materiale.IdMaterial))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMateriale", new { id = materiale.IdMaterial }, materiale);
        }

        // DELETE: api/Materiales/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMateriale(string id)
        {
            if (_context.Materiales == null)
            {
                return NotFound();
            }
            var materiale = await _context.Materiales.FindAsync(id);
            if (materiale == null)
            {
                return NotFound();
            }

            _context.Materiales.Remove(materiale);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MaterialeExists(string id)
        {
            return (_context.Materiales?.Any(e => e.IdMaterial == id)).GetValueOrDefault();
        }

        [HttpPost("check-duplicity")]
        public bool IsDuplicated(Materiale materiale)
        {
            // Really ugly expression due to nullable fields
            return _context.Materiales.Any(mat =>
                ((mat.NombreMaterial != null) ? mat.NombreMaterial.ToLower() : null) == ((materiale.NombreMaterial != null) ? materiale.NombreMaterial.ToLower() : null)
                && ((mat.UnidadDeMedida != null) ? mat.UnidadDeMedida.ToLower() : null) == ((materiale.UnidadDeMedida != null) ? materiale.UnidadDeMedida.ToLower() : null)
                && ((mat.Descripcion != null) ? mat.Descripcion.ToLower() : null) == ((materiale.Descripcion != null) ? materiale.Descripcion.ToLower() : null)
                && mat.Pvu == materiale.Pvu
                && ((mat.Marca != null) ? mat.Marca.ToLower() : null) == ((materiale.Marca != null) ? materiale.Marca.ToLower() : null));
        }
    }
}
