using System.ComponentModel.DataAnnotations;

namespace L02P02_2020PM605_2020SS601.Models
{
    public class autores
    {
        [Key]
        public int id { get; set; }
        public string autor { get; set; }
    }
}
