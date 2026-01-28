namespace Productos_ORM.Models
{
    public class AddProductoDto
    {
        public required string CodigoBarra { get; set; }
        public required string Nombre { get; set; }
        public string? Categoria { get; set; }
        public required decimal Precio { get; set; }

    }
}
