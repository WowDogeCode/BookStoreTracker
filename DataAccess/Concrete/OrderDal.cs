using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class OrderDal : EfEntityRepositoryBase<Order, BookStoreTrackerDBContext>, IOrderDal {  }
}
