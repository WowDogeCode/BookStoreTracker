using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class StockValidator : AbstractValidator<Stock>
    {
        public StockValidator()
        {
            RuleFor(stock => stock.Quantity)
                .LessThanOrEqualTo(1000).WithMessage("{PropertyName} of stock can't be more than 1000");
        }
    }
}
