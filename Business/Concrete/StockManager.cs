using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class StockManager : IStockManager
    {
        IStockDal _stockDal = new StockDal();
        public void Add(Stock t)
        {
            _stockDal.Add(t);
        }
        public void Delete(Stock t)
        {
            _stockDal.Delete(t);
        }
        public List<Stock> GetAll()
        {
            return _stockDal.GetAll();
        }
        public void Update(Stock t)
        {
            _stockDal.Update(t);
        }
    }
}
