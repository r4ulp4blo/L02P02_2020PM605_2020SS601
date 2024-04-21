using System.ComponentModel.DataAnnotations;

namespace L02P02_2020PM605_2020SS601.Models
{
    public class ComentariosPorLibroModel
    {
        [Key]
        public string comentario { get; set; }
        public string usuario { get; set; }
        public DateTime fecha { get; set; }
    }
}
