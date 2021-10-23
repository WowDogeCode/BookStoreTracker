using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IServiceRepository<T> where T: class, IEntity,new()
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetAll();
    }
}
