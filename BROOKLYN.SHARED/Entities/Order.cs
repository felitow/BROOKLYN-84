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


        // Propiedades de navegación para la relación con Delivery
        [Display(Name = "Entregas asociadas")]

        public int DeliveryId { get; set; }
        public Delivery Delivery { get; set; }
        public ICollection<Delivery> Deliveries { get; set; }




        // Propiedades de navegación para la relación con Cart
        [Display(Name = "Carritos asociados")]
        public ICollection<Cart> Carts { get; set; }



        // Propiedad de navegación para la relación con Customer
        [Display(Name = "Cliente")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


        [Display(Name = "Tipo de pago")]
        public int PayId { get; set; }
        public Pay Pay { get; set; }
    }
}
