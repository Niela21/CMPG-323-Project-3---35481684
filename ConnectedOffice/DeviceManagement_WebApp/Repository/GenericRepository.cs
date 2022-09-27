using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using DeviceManagement_WebApp.Data;
using System.Linq;
using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ConnectedOfficeContext _context;
        public GenericRepository(ConnectedOfficeContext context)
        {
            _context = context;
        }

        //generic method to add a record to the table
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        //generic method to get all the records from a table
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        //generic method to return a specific record based on the id
        public T GetById(Guid? id)
        {
            return _context.Set<T>().Find(id);
        }

        //generic method to remove a record
        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        //generic save method
        public void Save()
        {
            _context.SaveChangesAsync();
        }

        //generic method to update a record to the table
        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChangesAsync();
        }
    }

}
