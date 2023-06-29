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
    public class ProveedoresController : ControllerBase
    {
        private readonly InventarioDeipesaContext _context;

        public ProveedoresController(InventarioDeipesaContext context)
        {
            _context = context;
        }

        // GET: api/Proveedores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Proveedor>>> GetProveedors()
        {
            if (_context.Proveedors == null)
            {
                return NotFound();
            }
            return await _context.Proveedors.ToListAsync();
        }

        // GET: api/Proveedores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Proveedor>> GetProveedor(string id)
        {
            if (_context.Proveedors == null)
            {
                return NotFound();
            }
            var proveedor = await _context.Proveedors.FindAsync(id);

            if (proveedor == null)
            {
                return NotFound();
            }

            return proveedor;
        }

        // PUT: api/Proveedores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProveedor(string id, Proveedor proveedor)
        {
            if (id != proveedor.Idproveedor)
            {
                return BadRequest();
            }

            _context.Entry(proveedor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProveedorExists(id))
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

        // POST: api/Proveedores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Proveedor>> PostProveedor(Proveedor proveedor)
        {
            if (_context.Proveedors == null)
            {
                return Problem("Entity set 'InventarioDeipesaContext.Proveedors'  is null.");
            }
            _context.Proveedors.Add(proveedor);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProveedorExists(proveedor.Idproveedor))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProveedor", new { id = proveedor.Idproveedor }, proveedor);
        }

        // DELETE: api/Proveedores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProveedor(string id)
        {
            if (_context.Proveedors == null)
            {
                return NotFound();
            }
            var proveedor = await _context.Proveedors.FindAsync(id);
            if (proveedor == null)
            {
                return NotFound();
            }

            _context.Proveedors.Remove(proveedor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProveedorExists(string id)
        {
            return (_context.Proveedors?.Any(e => e.Idproveedor == id)).GetValueOrDefault();
        }

        [HttpGet("by-city/{cityId}")]
        public async Task<ActionResult<IEnumerable<Proveedor>>> GetByLocation(int cityId)
        {
            var result = await _context.Proveedors
                .Where(p => p.CiudadId == cityId)
                .ToListAsync();

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }
    }
}
