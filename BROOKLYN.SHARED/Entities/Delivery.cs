using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BROOKLYN.SHARED.Entities
{
    public class Delivery
    {
        public int Id { get; set; }



        

        // Otras propiedades...

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public Order Order { get; set; }


        public ICollection<Order> Orders { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
