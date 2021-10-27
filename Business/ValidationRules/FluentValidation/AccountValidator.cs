using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class AccountValidator : AbstractValidator<Account>
    {
        public AccountValidator()
        {
            RuleFor(account => account.Name)
                .NotEmpty().WithMessage("{PropertyName} can't be empty.");

            RuleFor(account => account.MailAdress)
                .NotEmpty().WithMessage("{PropertyName} can't be empty.")
                .EmailAddress().WithMessage("{PropertyName} not a valid mail adress."); 
            
            RuleFor(account => account.Password)
                .NotEmpty().WithMessage("{PropertyName} can't be empty.");

            RuleFor(account => account.Password).CheckPassword();
        }
    }
}
