using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROOKLYN.SHARED.Entities
{
    public class Order
    {

        public int Id { get; set; }


        [Display(Name = "Subtotal")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public decimal Subtotal { get; set; }


        [Display(Name = "Cliente")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public Customer Customer { get; set; }


        [Display(Name = "Total")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public decimal Total { get; set; }


        [Display(Name = "Estado")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string StateOrd { get; set; }


        [Display(Name = "Tipo de pago")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public Pay Pay { get; set; }


        [Display(Name = "Empleado a cargo")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public Employee Employee { get; set; }
    }
}
