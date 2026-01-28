namespace Productos_ORM.Models.Entities
{
    public class Producto
    {
        public Guid Id { get; set; }

        public required string CodigoBarra { get; set; }
        public required string Nombre { get; set; }
        public string? Categoria { get; set; }
        public required decimal Precio { get; set; }

    }
}
