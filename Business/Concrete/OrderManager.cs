using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderManager
    {
        IOrderDal _orderDal = new OrderDal();
        public void Add(Order t)
        {
            _orderDal.Add(t);
        }
        public void Delete(Order t)
        {
            _orderDal.Delete(t);
        }
        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }
        public void Update(Order t)
        {
            _orderDal.Update(t);
        }
        public List<OrderDetailDto> GetOrderDetails()
        {
            return _orderDal.GetOrderDetails();
        }
    }
}
