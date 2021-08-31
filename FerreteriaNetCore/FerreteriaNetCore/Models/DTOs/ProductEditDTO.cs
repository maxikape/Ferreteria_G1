using System;
namespace proyectoFerreteria.Models.DTOs
{
    public class ProductEditDTO
    {
        public string ProductName { get; set; }

        public string Brand { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }
    }
}
