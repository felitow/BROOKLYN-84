using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROOKLYN.SHARED.Entities
{

    public enum PaymentMethod
    {
        Efectivo,
        Tarjeta,
        Bono
    }


    public class Pay
    {

        public int Id { get; set; }


        [Display(Name = "Método de pago")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public PaymentMethod MethodPay { get; set; }

    }
}
