using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete
{
    public class OrderDal : EfEntityRepositoryBase<Order, BookStoreTrackerDBContext>, IOrderDal
    {
        public List<OrderDetailDto> GetOrderDetails()
        {
            using (BookStoreTrackerDBContext context = new BookStoreTrackerDBContext())
            {
                var result = from order in context.Orders
                             join account in context.Accounts
                             on order.AccountId equals account.AccountId
                             join product in context.Products
                             on order.ProductId equals product.ProductId
                             select new OrderDetailDto
                             {
                                 OrderDate = order.OrderDate,
                                 ProductName = product.ProductName,
                                 MailAdress = account.MailAdress
                             };

                return result.ToList();
            }
        }
    }
}
