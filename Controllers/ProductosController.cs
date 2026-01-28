using Microsoft.AspNetCore.Mvc;
using Productos_ORM.Data;
using Productos_ORM.Models;
using Productos_ORM.Models.Entities;

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

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetProductoById(Guid id)
        {
            var producto = dbContext.Productos.Find(id);
            if (producto == null)
            {
                return NotFound();
            }
            return Ok(producto);

        }

        [HttpPost]
                public IActionResult CreateProducto(AddProductoDto addProductoDto)
                {
                var productoEntity = new Producto()
                {
                    CodigoBarra = addProductoDto.CodigoBarra,
                    Nombre = addProductoDto.Nombre,
                    Categoria = addProductoDto.Categoria,
                    Precio = addProductoDto.Precio
                };
                dbContext.Productos.Add(productoEntity);
                dbContext.SaveChanges();
                return Ok(productoEntity); 
                }
        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateProducto(Guid id, UpdateProductoDto updateProductoDto)
        {
            var producto = dbContext.Productos.Find(id);
            if (producto == null)
            {
                return NotFound();
            }
            producto.CodigoBarra = updateProductoDto.CodigoBarra;
            producto.Nombre = updateProductoDto.Nombre;
            producto.Categoria = updateProductoDto.Categoria;
            producto.Precio = updateProductoDto.Precio;
            dbContext.SaveChanges();
            return Ok(producto);
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteProducto(Guid id) 
        {
            var producto = dbContext.Productos.Find(id);
            if (producto == null)
            {
                return NotFound();
            }
            dbContext.Productos.Remove(producto);
            dbContext.SaveChanges();
            return NoContent();
        }
    }

}
