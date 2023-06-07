using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        public async Task<ActionResult<List<Materiale>>> GetMateriales()
        {
            return Ok(await _context.Materiales
                .Include(m => m.DetalleOrdenCompras)
                .ToListAsync());
        }
    }
}
