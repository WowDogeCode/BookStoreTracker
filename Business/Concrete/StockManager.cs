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
    public class StockManager : IStockManager
    {
        IStockDal _stockDal = new StockDal();
        StockValidator _stockValidator = new StockValidator();
        public void Add(Stock stock)
        {
            var validationResult = _stockValidator.Validate(stock);
            if (_stockValidator.Validate(stock).IsValid)
            {
                _stockDal.Add(stock);
            }
            else
            {
                throw new ValidationException(validationResult.Errors);
            }
        }
        public void Delete(Stock t)
        {
            _stockDal.Delete(t);
        }
        public List<Stock> GetAll()
        {
            return _stockDal.GetAll();
        }
        public void Update(Stock stock)
        {
            var validationResult = _stockValidator.Validate(stock);
            if (_stockValidator.Validate(stock).IsValid)
            {
                _stockDal.Update(stock);
            }
            else
            {
                throw new ValidationException(validationResult.Errors);
            }
        }
    }
}
