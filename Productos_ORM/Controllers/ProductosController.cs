using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Productos_ORM.Data;

namespace Productos_ORM.Controllers
{
    //localhost:xxxx/api/employees
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public ProductosController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllProductos()
        {
            var allProductos = dbContext.Productos.ToList();

            return Ok(allProductos);

        }
    }
}
