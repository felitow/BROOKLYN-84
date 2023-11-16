using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROOKLYN.SHARED.Entities
{
    public class Customer
    {

        public int Id { get; set; }


        [Display(Name = "Nombre del cliente")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NameCustom { get; set; }



        [Display(Name = "Dirección de residencia del cliente")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string AddressCustom { get; set; }



        [Display(Name = "Número de teléfono del cliente")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string PhoneCustom { get; set; }



        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [EmailAddress]
        [Display(Name = "Email del cliente")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string EmailCustom { get; set; }



        [Display(Name = "Contraseña del cliente")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string PasswordCustom { get; set; }

    }
}
