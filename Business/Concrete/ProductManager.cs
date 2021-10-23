using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductManager
    {
        IProductDal _productDal = new ProductDal();
        public void Add(Product t)
        {
            _productDal.Add(t);
        }
        public void Delete(Product t)
        {
            _productDal.Delete(t);
        }
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
        public void Update(Product t)
        {
            _productDal.Update(t);
        }
    }
}
