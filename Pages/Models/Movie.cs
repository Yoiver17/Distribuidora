using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Productos { get; set; } = string.Empty;

        [DataType(DataType.Date)]
         [Display(Name = "Fecha Ingreso")]
        public DateTime fechaingreso { get; set; }
         [Display(Name = "Valor Unitario")]
        public decimal Valorunitario  { get; set; }
        public int Cantidad {get; set;}
        public decimal Precio { get; set; }

    }
}