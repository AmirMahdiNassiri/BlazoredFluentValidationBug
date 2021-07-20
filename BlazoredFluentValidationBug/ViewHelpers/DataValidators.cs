using BlazoredFluentValidationBug.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoredFluentValidationBug.ViewHelpers
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(address => address.Postcode).NotNull();
        }
    }

    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.Name).NotNull();
            RuleFor(customer => customer.Address).SetValidator(new AddressValidator());
        }
    }
}
