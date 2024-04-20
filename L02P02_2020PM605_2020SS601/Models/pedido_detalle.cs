using System.ComponentModel.DataAnnotations;

namespace L02P02_2020PM605_2020SS601.Models
{
    public class pedido_detalle
    {
        [Key]
        public int id { get; set; }
        public int id_pedido { get; set; }   
        public int id_libro { get; set; }
        public DateTime create_at { get; set; }
    }
}
