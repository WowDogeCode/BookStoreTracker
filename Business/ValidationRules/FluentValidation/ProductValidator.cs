using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(product => product.ProductName)
                .NotEmpty().WithMessage("{PropertyName} can't be empty.");
         
            RuleFor(product => product.ProductName)
                .Length(3,20).WithMessage("{PropertyName} length must be between 3-20 characters.");
        }
    }
}
