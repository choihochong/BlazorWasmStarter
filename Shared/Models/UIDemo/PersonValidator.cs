using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace BlazorStarterkitWasm.Shared.Models.UIDemo;

public class PersonValidator : AbstractValidator<Person>
{
    public PersonValidator()
    {
        RuleFor(vm => vm.FirstName)
            .NotEmpty()
            .MaximumLength(30);

        RuleFor(vm => vm.LastName)
            .NotEmpty()
            .MaximumLength(30);

        RuleFor(vm => vm.Age)
            .GreaterThanOrEqualTo(18);
    }
}
