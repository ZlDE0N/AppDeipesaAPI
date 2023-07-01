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
    public class ProformasController : ControllerBase
    {
        private readonly InventarioDeipesaContext _context;

        public ProformasController(InventarioDeipesaContext context)
        {
            _context = context;
        }

        // GET: api/Proformas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Proforma>>> GetProformas()
        {
            if (_context.Proformas == null)
            {
                return NotFound();
            }
            return await _context.Proformas.Include(p => p.Ciudad).ToListAsync();
        }

        // GET: api/Proformas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Proforma>> GetProforma(long id)
        {
            if (_context.Proformas == null)
            {
                return NotFound();
            }
            var proforma = await _context.Proformas.FindAsync(id);

            if (proforma == null)
            {
                return NotFound();
            }

            return proforma;
        }

        // PUT: api/Proformas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProforma(long id, Proforma proforma)
        {
            if (id != proforma.Id)
            {
                return BadRequest();
            }

            _context.Entry(proforma).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProformaExists(id))
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

        // POST: api/Proformas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Proforma>> PostProforma(Proforma proforma)
        {
            if (_context.Proformas == null)
            {
                return Problem("Entity set 'InventarioDeipesaContext.Proformas'  is null.");
            }
            _context.Proformas.Add(proforma);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProforma", new { id = proforma.Id }, proforma);
        }

        // DELETE: api/Proformas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProforma(long id)
        {
            if (_context.Proformas == null)
            {
                return NotFound();
            }
            var proforma = await _context.Proformas.FindAsync(id);
            if (proforma == null)
            {
                return NotFound();
            }

            _context.Proformas.Remove(proforma);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProformaExists(long id)
        {
            return (_context.Proformas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
