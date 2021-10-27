using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderManager
    {
        IOrderDal _orderDal = new OrderDal();
        OrderValidator _orderValidator = new OrderValidator();
        public void Add(Order order)
        {
            var validationResult = _orderValidator.Validate(order);
            if (_orderValidator.Validate(order).IsValid)
            {
                _orderDal.Add(order);
            }
            else
            {
                throw new ValidationException(validationResult.Errors);
            }
        }
        public void Delete(Order t)
        {
            _orderDal.Delete(t);
        }
        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }
        public void Update(Order order)
        {
            var validationResult = _orderValidator.Validate(order);
            if (_orderValidator.Validate(order).IsValid)
            {
                _orderDal.Update(order);
            }
            else
            {
                throw new ValidationException(validationResult.Errors);
            }
        }
        public List<OrderDetailDto> GetOrderDetails()
        {
            return _orderDal.GetOrderDetails();
        }
    }
}
