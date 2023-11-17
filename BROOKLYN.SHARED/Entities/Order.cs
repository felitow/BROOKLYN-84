using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BROOKLYN.SHARED.Entities
{
    public class Order
    {
        public int Id { get; set; }

        [Display(Name = "Subtotal")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public decimal Subtotal { get; set; }

        [Display(Name = "Total")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public decimal Total { get; set; }

        [Display(Name = "Estado")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string StateOrd { get; set; }



        [Display(Name = "Empleado a cargo")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }


        public int CartId { get; set; }
        public Cart Cart { get; set; }

        public int PayId { get; set; }
        public Pay Pay { get; set; }


        public int DeliveryId { get; set; }
        public Delivery Delivery { get; set; }
    }
}
