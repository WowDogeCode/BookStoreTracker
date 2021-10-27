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
    public class ProductManager : IProductManager
    {
        IProductDal _productDal = new ProductDal();
        ProductValidator _productValidator = new ProductValidator();
        public void Add(Product t)
        {
            var validationResult = _productValidator.Validate(t);
            if (validationResult.IsValid)
            {
                _productDal.Add(t);
            }
            else
            {
                throw new ValidationException(validationResult.Errors);
            }
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
            var validationResult = _productValidator.Validate(t);
            if (_productValidator.Validate(t).IsValid)
            {
                _productDal.Update(t);
            }
            else
            {
                throw new ValidationException(validationResult.Errors);
            }
        }
    }
}
