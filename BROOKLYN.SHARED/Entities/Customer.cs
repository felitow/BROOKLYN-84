using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BROOKLYN.SHARED.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del cliente")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string NameCustom { get; set; }

        [Display(Name = "Dirección de residencia del cliente")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string AddressCustom { get; set; }

        [Display(Name = "Número de teléfono del cliente")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string PhoneCustom { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [EmailAddress]
        [Display(Name = "Email del cliente")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        public string EmailCustom { get; set; }

        [Display(Name = "Contraseña del cliente")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string PasswordCustom { get; set; }


        public ICollection<Delivery> Deliveries { get; set; }
    }
}
