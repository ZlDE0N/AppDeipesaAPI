﻿using System;
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
    public class ContratosController : ControllerBase
    {
        private readonly InventarioDeipesaContext _context;

        public ContratosController(InventarioDeipesaContext context)
        {
            _context = context;
        }

        // GET: api/Contratos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contrato>>> GetContratos()
        {
            if (_context.Contratos == null)
            {
                return NotFound();
            }
            return await _context.Contratos.ToListAsync();
        }

        // GET: api/Contratos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contrato>> GetContrato(long id)
        {
            if (_context.Contratos == null)
            {
                return NotFound();
            }
            var contrato = await _context.Contratos.FindAsync(id);

            if (contrato == null)
            {
                return NotFound();
            }

            return contrato;
        }

        // PUT: api/Contratos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContrato(long id, Contrato contrato)
        {
            if (id != contrato.Id)
            {
                return BadRequest();
            }

            _context.Entry(contrato).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContratoExists(id))
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

        // POST: api/Contratos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Contrato>> PostContrato(Contrato contrato)
        {
            if (_context.Contratos == null)
            {
                return Problem("Entity set 'InventarioDeipesaContext.Contratos'  is null.");
            }
            _context.Contratos.Add(contrato);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContrato", new { id = contrato.Id }, contrato);
        }

        // DELETE: api/Contratos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContrato(long id)
        {
            if (_context.Contratos == null)
            {
                return NotFound();
            }
            var contrato = await _context.Contratos.FindAsync(id);
            if (contrato == null)
            {
                return NotFound();
            }

            _context.Contratos.Remove(contrato);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContratoExists(long id)
        {
            return (_context.Contratos?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        [HttpGet("by-city/{cityId}")]
        public async Task<ActionResult<IEnumerable<Contrato>>> GetByCity(long cityId)
        {
            var result = await _context.Contratos
                .Include(c => c.Cliente)
                    .ThenInclude(cl => cl!.Ciudad)
                .Where(c => c.Cliente!.Ciudad!.Id == cityId)
                .AsSplitQuery()
                .AsNoTracking()
                .ToListAsync();

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }
    }
}
