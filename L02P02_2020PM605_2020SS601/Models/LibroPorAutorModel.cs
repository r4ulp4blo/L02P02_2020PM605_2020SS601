using System.ComponentModel.DataAnnotations;

namespace L02P02_2020PM605_2020SS601.Models
{
    public class LibroPorAutorModel
    {
        [Key]
        public string NombreLibro { get; set; }
        public string DescripcionLibro { get; set; }
        public decimal PrecioLibro { get; set; }
        public string NombreAutor { get; set; }
    }
}

