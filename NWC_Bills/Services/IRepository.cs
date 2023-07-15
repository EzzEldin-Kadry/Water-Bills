using System.Linq.Expressions;

namespace NWC.Repository
{
    public interface IRepository<T>  where T : class
    {
        IList<T> GetAll(Expression<Func<T,bool>> filter = null, bool istracking = false, string? includeProperties = null);
        T GetFirstOrDefault(Expression<Func<T, bool>> filter, bool istracking = false, string? includeProperties = null);
    }
}
