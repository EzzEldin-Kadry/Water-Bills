using Microsoft.EntityFrameworkCore;
using NWC_Bills;
using System.Linq.Expressions;

namespace NWC.Repository
{
    public class Repository<T>  : IRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;
        public Repository(ApplicationDbContext db)
        {
            this._db = db;
            this.dbSet = db.Set<T>();
        }

        public IList<T> GetAll(Expression<Func<T, bool>> filter = null, bool istracking = false, string? includeProperties = null)
        {
            IQueryable<T> query;
            if (istracking)
                query = dbSet;
            else
                query = dbSet.AsNoTracking();
            if (filter is not null)
                query = query.Where(filter);
            if (includeProperties is not null)
            {
                foreach (var includeProp in includeProperties.
                    Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    query = query.Include(includeProp);
            }
            return query.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter, bool istracking = false, string? includeProperties = null)
        {
            IQueryable<T> query;
            if (istracking)
                query = dbSet;
            else
                query = dbSet.AsNoTracking();
            if(includeProperties is not null)
            {
                foreach (var includeProp in includeProperties.
                    Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    query = query.Include(includeProp);
            }
            return  query.FirstOrDefault(filter);
        }
    }
}
