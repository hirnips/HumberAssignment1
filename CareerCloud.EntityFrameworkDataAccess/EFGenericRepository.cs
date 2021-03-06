﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.EntityFrameworkDataAccess
{
    public class EFGenericRepository<T> : IDataRepository<T> where T : class
    {
        private CareerCloudContext _context;

        public EFGenericRepository(bool createProxy = true)
        {
            _context = new CareerCloudContext(createProxy);
        }
        public void Add(params T[] items)
        {
            foreach (var item in items)
            {
                _context.Entry(item).State = EntityState.Added;
            }
            _context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> dbQuery = _context.Set<T>();
            foreach (var navprop in navigationProperties)
            {
                dbQuery = dbQuery.Include<T, object>(navprop);
            }
            return dbQuery.ToList<T>();
            //throw new NotImplementedException();
        }

        public IList<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> dbQuery = _context.Set<T>();
            foreach (var navprop in navigationProperties)
            {
                dbQuery = dbQuery.Include<T, object>(navprop);
            }
            return dbQuery.Where(where).ToList<T>();
            //throw new NotImplementedException();
        }

        public T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> dbQuery = _context.Set<T>();
            foreach (Expression<Func<T, object>> navprop in navigationProperties)
            {
                dbQuery = dbQuery.Include<T, object>(navprop);
            }
            return dbQuery.FirstOrDefault(where);
            //throw new NotImplementedException();
        }

        public void Remove(params T[] items)
        {
            foreach (var item in items)
            {
                _context.Entry(item).State = EntityState.Deleted;
            }
            _context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void Update(params T[] items)
        {
            foreach (var item in items)
            {
                _context.Entry(item).State = EntityState.Modified;
            }
            _context.SaveChanges();
            //throw new NotImplementedException();
        }
    }
}
