using System.ComponentModel.DataAnnotations;

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



        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
