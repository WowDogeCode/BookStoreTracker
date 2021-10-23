using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AccountManager : IAccountManager
    {
        IAccountDal _accountDal = new AccountDal();
        public void Add(Account t)
        {
            _accountDal.Add(t);
        }
        public void Delete(Account t)
        {
            _accountDal.Delete(t);
        }
        public List<Account> GetAll()
        {
            return _accountDal.GetAll();
        }
        public void Update(Account t)
        {
            _accountDal.Update(t);
        }
    }

    //TODO : Add business rules. .
}
