using ExcelOperations.Context;
using System.Linq.Expressions;

namespace ExcelOperations.Repository.Implementor
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly EntityDbContext _dbContext;
        public GenericRepository(EntityDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _dbContext.Set<T>().AddRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public IEnumerable<T> GetByFilter(Expression<Func<T, bool>> filter)
        {
            return _dbContext.Set<T>().Where(filter);
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            _dbContext.Set< T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
           _dbContext.Set<T>().RemoveRange(entities);
        }

        public Task BulkSaveAsync(IEnumerable<object> entity, CancellationToken cancellationToken)
        {
            return _dbContext.BulkInsertAsync(entity,cancellationToken);
        } 
        public int SaveEntity(T entity)
        {
            return _dbContext.SaveChanges();
        }
    }
}
