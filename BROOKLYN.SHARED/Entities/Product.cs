using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BROOKLYN.SHARED.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del producto")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string NameProd { get; set; }

        [Display(Name = "Stock")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public decimal StockProd { get; set; }

        [Display(Name = "Precio Unitario")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public decimal PriceProd { get; set; }

        // Propiedad de navegación para la relación con Employee
        [Display(Name = "Empleado que lo creó")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }


        public ICollection<CartProduct> CartProducts { get; set; }

    }
}
