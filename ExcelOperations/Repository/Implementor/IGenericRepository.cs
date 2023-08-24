using System.Linq.Expressions;

namespace ExcelOperations.Repository.Implementor
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetByFilter(Expression<Func<T, bool>> filter);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        Task BulkSaveAsync(IEnumerable<object> entity, CancellationToken cancellationToken);
        int SaveEntity(T entity);
    }
}