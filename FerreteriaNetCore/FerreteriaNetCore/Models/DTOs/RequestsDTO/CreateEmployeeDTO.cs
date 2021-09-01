using System;
namespace proyectoFerreteria.Models.DTOs
{
    public class CreateEmployeeDTO
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string File { get; set; }

        public string Category { get; set; }

        public string DniNumber { get; set; }

        public string dniType { get; set; }
    }
}