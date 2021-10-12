using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        List<T> GetAllByCategory(int categoryId);



        /*
         BİLGE ADAM BLOG PROJESİ IREPOSİTORY METHODLARI
            Task<T> Add(T item);
            Task<bool> AddRange(List<T> items);
            Task<T> Update(T item);
            Task<bool> Remove(T item);
            Task<bool> RemoveAll(Expression<Func<T, bool>> exp);
            Task<T> GetById(Guid id, params Expression<Func<T, object>>[] includeParameters);
            Task<T> GetByDefault(Expression<Func<T, bool>> exp, params Expression<Func<T, object>>[] includeParameters);
            IQueryable<T> GetActive();
            IQueryable<T> GetDefault(Expression<Func<T, bool>> exp, params Expression<Func<T, object>>[] includeParameters);
            IQueryable<T> Table { get; }
            IQueryable<T> TableNoTracking { get; }
            Task<bool> Activate(Guid id);
            Task<bool> Any(Expression<Func<T, bool>> exp);
            Task<int> Save();
         */
    }
}
