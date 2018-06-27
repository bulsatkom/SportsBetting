using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Betting_Data.Interfaces
{
    public interface IEfDbSetWrapper<T>
        where T : class
    {
        IQueryable<T> All { get; }

        T GetById(Guid id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        int SaveChanges();
    }
}
