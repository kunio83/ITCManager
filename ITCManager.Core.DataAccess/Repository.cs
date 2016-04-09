﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ITCManager.Core.Entities;
using System.Data.Entity.Validation;

namespace ITCManager.Core.DataAccess
{
    public class Repository<T> where T : class
    {
        private readonly ITC_DBPOwerEntities context;
        private IDbSet<T> entities;
        string errorMessage = string.Empty;

        public Repository(ITC_DBPOwerEntities context)
        {
            this.context = context;
        }

        public T GetById(object id)
        {
            return this.Entities.Find(id);
        }

        public void Insert(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this.Entities.Add(entity);
                this.context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        errorMessage += string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage) + Environment.NewLine;
                    }
                }
                throw new Exception(errorMessage, dbEx);
            }
        }

        public void Update(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this.context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        errorMessage += Environment.NewLine + string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }

                throw new Exception(errorMessage, dbEx);
            }
        }

        public void Delete(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }

                this.Entities.Remove(entity);
                this.context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        errorMessage += Environment.NewLine + string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
                throw new Exception(errorMessage, dbEx);
            }
        }

        public virtual IQueryable<T> Table
        {
            get
            {
                return this.Entities;
            }
        }

        private IDbSet<T> Entities
        {
            get
            {
                if (entities == null)
                {
                    entities = context.Set<T>();
                }
                return entities;
            }
        }
    }
    //public class Repository<T> : IRepository<T> where T:class 
    //{
    //    public DbContext context;
    //    public DbSet<T> dbset;
    //    public Repository(DbContext context)
    //    {
    //        this.context = context;
    //        dbset = context.Set<T>();
    //    }
    //    public Repository()
    //    {

    //    }


    //    public T GetById(int id)
    //    {
    //        return dbset.Find(id);
    //    }

    //    public IQueryable<T> GetAll()
    //    {
    //        return dbset;
    //    }
    //    public void Insert(T entity)
    //    {
    //        dbset.Add(entity);
    //    }

    //    public void Edit(T entity)
    //    {
    //        context.Entry(entity).State = EntityState.Modified;
    //    }

    //    public void Delete(T entity)
    //    {
    //        context.Entry(entity).State = EntityState.Deleted;
    //    }
    //}
}