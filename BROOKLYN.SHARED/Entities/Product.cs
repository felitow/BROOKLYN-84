using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROOKLYN.SHARED.Entities
{
    public class Product
    {

        public int Id { get; set; }


        [Display(Name = "Nombre del producto")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NameProd { get; set; }


        [Display(Name = "Stock")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public decimal StockProd { get; set; }


        [Display(Name = "Precio Unitario")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public float PriceProd { get; set; }


        [Display(Name = "Empleado que lo creo")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public Employee Employee { get; set; }
    }
}
