using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROOKLYN.SHARED.Entities
{
    public class Cart
    {

        public int Id { get; set; }


        [Display(Name = "Pedido a cargo")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public Order Order { get; set; }


        [Display(Name = "Producto a cargo")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public Product Product { get; set; }


        [Display(Name = "Cantidad")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public decimal AmountCart { get; set; }


        [Display(Name = "Total de la factura")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public float PriceCart { get; set; }


        [Display(Name = "Estado")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string StateCart { get; set; }
    }
}
