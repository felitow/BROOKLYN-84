using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROOKLYN.SHARED.Entities
{
    public class Delivery
    {

        public int ID { get; set; }


        [Display(Name = "Pedido a cargo")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public Order Order { get; set; }


        [Display(Name = "Empleado a cargo")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public Employee Employee { get; set; }
    }
}
