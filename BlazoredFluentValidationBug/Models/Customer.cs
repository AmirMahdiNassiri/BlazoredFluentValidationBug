using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoredFluentValidationBug.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public Customer()
        {
            Address = new Address();
        }
    }
}
