using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROOKLYN.SHARED.Entities
{


    public enum EmployeeType
    {
        Administrador,
        Vendedor,
        Domiciliario,
        Desarrolador
    }

    public class Employee
    {

        public int Id { get; set; }


        [Display(Name = "Nombre del empleado")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NameEmpl { get; set; }



        [Display(Name = "Dirección de residencia del empleado")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string AddressEmpl { get; set; }



        [Display(Name = "Número de teléfono del empleado")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string PhoneEmpl { get; set; }



        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [EmailAddress]
        [Display(Name = "Email del empleado")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string EmailEmpl { get; set; }



        [Display(Name = "Contraseña del empleado")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string PasswordEmpl { get; set; }



        [Display(Name = "Cargo del empleado")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public EmployeeType EmployeeType { get; set; }

    }
}
