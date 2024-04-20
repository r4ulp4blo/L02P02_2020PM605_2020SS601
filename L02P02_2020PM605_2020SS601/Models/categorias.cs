using System.ComponentModel.DataAnnotations;

namespace L02P02_2020PM605_2020SS601.Models
{
    public class categorias
    {
        [Key]
        public int id { get; set; }
        public string categoria { get; set; }
    }
}
