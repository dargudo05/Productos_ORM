namespace Productos_ORM.Models
{
    public class UpdateProductoDto
    {
        public required string CodigoBarra { get; set; }
        public required string Nombre { get; set; }
        public string? Categoria { get; set; }
        public required decimal Precio { get; set; }
    }
}
