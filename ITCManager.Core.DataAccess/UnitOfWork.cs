using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ITCManager.Core.Entities;

namespace ITCManager.Core.DataAccess
{
    public class UnitOfWork : IDisposable
    {
        private readonly ITC_DBPOwerEntities context;
        private bool disposed;
        private Dictionary<string, object> repositories;

        public UnitOfWork(ITC_DBPOwerEntities context)
        {
            this.context = context;
        }

        public UnitOfWork()
        {
            context = new ITC_DBPOwerEntities();
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

    //public interface IUnitOfWork : IDisposable
    //{
    //    IRepository<Persona> PersonaRepository { get; }
    //    IRepository<Ciudad> CiudadRepository { get; }
    //    void Save();
    //}

    //public partial class UnitOfWork : IUnitOfWork
    //{
    //    private ITC_DBPOwerEntities _context;

    //    //Add any new repository from here 
    //    private IRepository<Persona> _personaRepository;
    //    private IRepository<Ciudad> _ciudadRepository;

    //    public IRepository<Persona> PersonaRepository
    //    {
    //        get {

    //            if (_personaRepository==null)
    //                _personaRepository = new Repository<Persona>(_context);

    //            return _personaRepository; }
    //    }
    //    public IRepository<Ciudad> CiudadRepository
    //    {
    //        get
    //        {
    //            if (_ciudadRepository == null)
    //                _ciudadRepository = new Repository<Ciudad>(_context);

    //            return _ciudadRepository;
    //        }
    //    }

    //    public UnitOfWork()
    //    {
    //        _context=new ITC_DBPOwerEntities();
    //    }
    //    public void Save()
    //    {
    //        _context.SaveChanges();
    //    }
    //    public void Dispose()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}