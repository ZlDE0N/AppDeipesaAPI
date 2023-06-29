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
    public class AlmacenesController : ControllerBase
    {
        private readonly InventarioDeipesaContext _context;

        public AlmacenesController(InventarioDeipesaContext context)
        {
            _context = context;
        }

        // GET: api/Almacenes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Almacen>>> GetAlmacens()
        {
            if (_context.Almacens == null)
            {
                return NotFound();
            }
            return await _context.Almacens.ToListAsync();
        }

        // GET: api/Almacenes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Almacen>> GetAlmacen(string id)
        {
            if (_context.Almacens == null)
            {
                return NotFound();
            }
            var almacen = await _context.Almacens.FindAsync(id);

            if (almacen == null)
            {
                return NotFound();
            }

            return almacen;
        }

        // PUT: api/Almacenes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlmacen(string id, Almacen almacen)
        {
            if (id != almacen.IdAlmacen)
            {
                return BadRequest();
            }

            _context.Entry(almacen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlmacenExists(id))
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

        // POST: api/Almacenes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Almacen>> PostAlmacen(Almacen almacen)
        {
            if (_context.Almacens == null)
            {
                return Problem("Entity set 'InventarioDeipesaContext.Almacens'  is null.");
            }
            _context.Almacens.Add(almacen);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AlmacenExists(almacen.IdAlmacen))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAlmacen", new { id = almacen.IdAlmacen }, almacen);
        }

        // DELETE: api/Almacenes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlmacen(string id)
        {
            if (_context.Almacens == null)
            {
                return NotFound();
            }
            var almacen = await _context.Almacens.FindAsync(id);
            if (almacen == null)
            {
                return NotFound();
            }

            _context.Almacens.Remove(almacen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlmacenExists(string id)
        {
            return (_context.Almacens?.Any(e => e.IdAlmacen == id)).GetValueOrDefault();
        }

        [HttpGet("by-location/{id}")]
        public async Task<ActionResult<Almacen>> GetStorageByLocation(long locationId)
        {
            var result = await _context.Almacens
                    .Include(a => a.Inventarios)
                        .ThenInclude(i => i.IdMaterialNavigation)
                    .Where(a => a.CiudadId == locationId)
                    .AsNoTracking()
                    .AsSplitQuery()
                    .FirstOrDefaultAsync();

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }
    }
}
