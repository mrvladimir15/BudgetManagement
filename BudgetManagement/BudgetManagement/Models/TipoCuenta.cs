using System.ComponentModel.DataAnnotations;

namespace BudgetManagement.Models
{
    public class TipoCuenta
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="El campo {0} está vacío.")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "El campo debe tener una longitud de entre {2} y {1} caracteres.")]
        [Display(Name = "Nombre del tipo de cuenta")]
        public string nombre { get; set; }
        public int usuarioID { get; set; }
        public int orden { get; set; }
    }
}
