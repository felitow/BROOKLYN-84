using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BROOKLYN.SHARED.Entities
{
    

    public class Employee
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del empleado")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string NameEmpl { get; set; }

        [Display(Name = "Dirección de residencia del empleado")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string AddressEmpl { get; set; }

        [Display(Name = "Número de teléfono del empleado")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string PhoneEmpl { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [EmailAddress]
        [Display(Name = "Email del empleado")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        public string EmailEmpl { get; set; }

        [Display(Name = "Contraseña del empleado")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string PasswordEmpl { get; set; }

        [Display(Name = "Cargo del empleado")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string EmployeeType { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<Product> Products { get; set; }

        public ICollection<Delivery> Deliveries { get; set; }
    }
}
