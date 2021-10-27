using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AccountManager : IAccountManager
    {
        IAccountDal _accountDal = new AccountDal();
        AccountValidator _accountValidator = new AccountValidator();
        public void Add(Account account)
        {
            var validationResult = _accountValidator.Validate(account);
            if (_accountValidator.Validate(account).IsValid)
            {
                _accountDal.Add(account);
            }
            else
            {
                throw new ValidationException(validationResult.Errors);
            }
        }
        public void Delete(Account t)
        {
            _accountDal.Delete(t);
        }
        public List<Account> GetAll()
        {
            return _accountDal.GetAll();
        }
        public void Update(Account account)
        {
            var validationResult = _accountValidator.Validate(account);
            if (_accountValidator.Validate(account).IsValid)
            {
                _accountDal.Update(account);
            }
            else
            {
                throw new ValidationException(validationResult.Errors);
            }
        }
    }
}
