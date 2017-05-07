using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ITCManager.Client.Entities_Client;

namespace ITCManager.Client.DataAccess_Client.DBTools
{
    public class UnitOfWork : IDisposable
    {
        private readonly SqliteClientDataBaseEntitiesFinal context;
        private bool disposed;
        private Dictionary<string, object> repositories;

        public UnitOfWork(SqliteClientDataBaseEntitiesFinal context)
        {
            this.context = context;
        }

        public UnitOfWork()
        {
            context = new SqliteClientDataBaseEntitiesFinal();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public Repository<T> Repository<T>() where T : class
        {
            if (repositories == null)
            {
                repositories = new Dictionary<string, object>();
            }

            var type = typeof(T).Name;

            if (!repositories.ContainsKey(type))
            {
                var repositoryType = typeof(Repository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), context);
                repositories.Add(type, repositoryInstance);
            }
            return (Repository<T>)repositories[type];
        }
    }
}