using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BROOKLYN.SHARED.Entities
{
    public class Delivery
    {
        public int Id { get; set; }



        // Propiedades de navegación para la relación con Order
        [Display(Name = "Pedidos asociados")]
        public ICollection<Order> Orders { get; set; }



        // Propiedades de navegación para la relación con Employee
        [Display(Name = "Empleados asociados")]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
