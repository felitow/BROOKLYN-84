using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BROOKLYN.SHARED.Entities
{
    public class Cart
    {
        public int Id { get; set; }

        [Display(Name = "Cantidad")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public decimal AmountCart { get; set; }

        [Display(Name = "Total de la factura")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public float PriceCart { get; set; }

        [Display(Name = "Estado")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string StateCart { get; set; }


        // Propiedades de navegación para la relación con Order
        [Display(Name = "Pedidos asociados")]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public ICollection<Order> Orders { get; set; }


        public ICollection<CartProduct> CartProducts { get; set; }

        // Propiedades de navegación para la relación con Product (asumiendo una relación muchos a muchos)
        [Display(Name = "Productos en el carrito")]
        public ICollection<Product> Products { get; set; }
    }
}