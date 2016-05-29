using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFSandbox.Web.Models.Repositories
{
    public class Repository<T> where T : class
    {

        private EFSandboxDbContext context = null;

        protected DbSet<T> DbSet
        {
            get;
            set;
        }

        public Repository()
        {
            context = new EFSandboxDbContext();
            DbSet = context.Set<T>();
        }

        public Repository(EFSandboxDbContext context)
        {
            this.context = context;
            DbSet = context.Set<T>();
        }

        public virtual List<T> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual T Get(int id)
        {
            return DbSet.Find(id);
        }

        public virtual void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public virtual void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}