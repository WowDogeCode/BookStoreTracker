using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public static class FluentValidationExtensions
    {
        public static IRuleBuilderOptions<T, string> CheckPassword<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder
                       .NotEmpty()
                       .MinimumLength(8)
                       .Matches("[A-Z]").WithMessage("'{PropertyName}' must contain one or more capital letters.")
                       .Matches("[a-z]").WithMessage("'{PropertyName}' must contain one or more lowercase letters.")
                       .Matches(@"\d").WithMessage("'{PropertyName}' must contain one or more digits.")
                       .Matches(@"[][""!@$%^&*(){}:;<>,.?/+_=|'~\\-]").WithMessage("'{ PropertyName}' must contain one or more special characters.")
                       .Matches("^[^£# “”]*$").WithMessage("'{PropertyName}' must not contain the following characters £ # “” or spaces.");
        }
    }
}
