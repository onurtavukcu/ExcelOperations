using ExcelOperations.Context;
using ExcelOperations.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ExcelOperations.Extensions
{
    public static class AppDataConnectionExtensions
    {
        private static IQueryable<T> Table<T>(this EntityDbContext connection) where T : class, IEntityBase
            => connection.Set<T>();

        private static TResult ExecuteSafe<TResult>(Func<TResult> operation, TResult defaultValue = default)
        {
            try
            {
                return operation();
            }
            catch (InvalidOperationException)
            {
                return defaultValue;
            }
            catch (ArgumentNullException)
            {
                return defaultValue;
            }
            catch (NotSupportedException)
            {
                return defaultValue;
            }
        }

        private static async Task<TResult> ExecuteSafeAsync<TResult>(Func<Task<TResult>> operation, TResult defaultValue = default)
        {
            try
            {
                return await operation();
            }
            catch (InvalidOperationException)
            {
                return defaultValue;
            }
            catch (ArgumentNullException)
            {
                return defaultValue;
            }
            catch (NotSupportedException)
            {
                return defaultValue;
            }
        }

        // ---------- Basic ----------
        public static IQueryable<T> GetAll<T>(this EntityDbContext connection) where T : class, IEntityBase
            => connection.Table<T>();

        public static T? GetById<T>(this EntityDbContext connection, int id) where T : class, IEntityBase
            => ExecuteSafe(() => connection.Table<T>().FirstOrDefault(x => x.id == id));

        public static async Task<T?> GetByIdAsync<T>(this EntityDbContext connection, int id) where T : class, IEntityBase
            => await ExecuteSafeAsync(() => connection.Table<T>().FirstOrDefaultAsync(x => x.id == id));

        public static T? GetFirst<T>(this EntityDbContext connection, Expression<Func<T, bool>>? predicate = null) where T : class, IEntityBase
        {
            var query = connection.Table<T>();
            if (predicate != null)
                query = query.Where(predicate);
            
            return ExecuteSafe(() => query.FirstOrDefault());
        }

        public static async Task<T?> GetFirstAsync<T>(this EntityDbContext connection, Expression<Func<T, bool>>? predicate = null) where T : class, IEntityBase
        {
            var query = connection.Table<T>();
            if (predicate != null)
                query = query.Where(predicate);
            
            return await ExecuteSafeAsync(() => query.FirstOrDefaultAsync());
        }

        public static T? GetSingle<T>(this EntityDbContext connection, Expression<Func<T, bool>>? predicate = null) where T : class, IEntityBase
        {
            var query = connection.Table<T>();
            if (predicate != null)
                query = query.Where(predicate);
            
            return ExecuteSafe(() => query.SingleOrDefault());
        }

        public static async Task<T?> GetSingleAsync<T>(this EntityDbContext connection, Expression<Func<T, bool>>? predicate = null) where T : class, IEntityBase
        {
            var query = connection.Table<T>();
            if (predicate != null)
                query = query.Where(predicate);
            
            return await ExecuteSafeAsync(() => query.SingleOrDefaultAsync());
        }

        public static IQueryable<T> Where<T>(this EntityDbContext connection, Expression<Func<T, bool>> predicate) where T : class, IEntityBase
            => connection.Table<T>().Where(predicate);

        public static bool Any<T>(this EntityDbContext connection, Expression<Func<T, bool>>? predicate = null) where T : class, IEntityBase
        {
            var query = connection.Table<T>();
            if (predicate != null)
                query = query.Where(predicate);
            
            return ExecuteSafe(() => query.Any());
        }

        public static async Task<bool> AnyAsync<T>(this EntityDbContext connection, Expression<Func<T, bool>>? predicate = null) where T : class, IEntityBase
        {
            var query = connection.Table<T>();
            if (predicate != null)
                query = query.Where(predicate);
            
            return await ExecuteSafeAsync(() => query.AnyAsync());
        }

        public static int Count<T>(this EntityDbContext connection, Expression<Func<T, bool>>? predicate = null) where T : class, IEntityBase
        {
            var query = connection.Table<T>();
            if (predicate != null)
                query = query.Where(predicate);
            
            return ExecuteSafe(() => query.Count());
        }

        public static async Task<int> CountAsync<T>(this EntityDbContext connection, Expression<Func<T, bool>>? predicate = null) where T : class, IEntityBase
        {
            var query = connection.Table<T>();
            if (predicate != null)
                query = query.Where(predicate);
            
            return await ExecuteSafeAsync(() => query.CountAsync());
        }

        // ---------- CRUD Operations ----------
        public static T Add<T>(this EntityDbContext connection, T entity) where T : class, IEntityBase
        {
            connection.Set<T>().Add(entity);
            return entity;
        }

        public static void AddRange<T>(this EntityDbContext connection, IEnumerable<T> entities) where T : class, IEntityBase
        {
            connection.Set<T>().AddRange(entities);
        }

        public static T Update<T>(this EntityDbContext connection, T entity) where T : class, IEntityBase
        {
            connection.Set<T>().Update(entity);
            return entity;
        }

        public static void UpdateRange<T>(this EntityDbContext connection, IEnumerable<T> entities) where T : class, IEntityBase
        {
            connection.Set<T>().UpdateRange(entities);
        }

        public static void Delete<T>(this EntityDbContext connection, T entity) where T : class, IEntityBase
        {
            connection.Set<T>().Remove(entity);
        }

        public static void Delete<T>(this EntityDbContext connection, int id) where T : class, IEntityBase
        {
            var entity = connection.GetById<T>(id);
            if (entity != null)
                connection.Set<T>().Remove(entity);
        }

        public static void DeleteRange<T>(this EntityDbContext connection, IEnumerable<T> entities) where T : class, IEntityBase
        {
            connection.Set<T>().RemoveRange(entities);
        }

        public static void DeleteWhere<T>(this EntityDbContext connection, Expression<Func<T, bool>> predicate) where T : class, IEntityBase
        {
            var entities = connection.Table<T>().Where(predicate).ToList();
            if (entities.Any())
                connection.Set<T>().RemoveRange(entities);
        }

        public static async Task DeleteWhereAsync<T>(this EntityDbContext connection, Expression<Func<T, bool>> predicate) where T : class, IEntityBase
        {
            var entities = await connection.Table<T>().Where(predicate).ToListAsync();
            if (entities.Any())
                connection.Set<T>().RemoveRange(entities);
        }

        // ---------- Save Operations ----------
        public static int SaveChanges(this EntityDbContext connection)
            => ExecuteSafe(() => connection.SaveChanges(), 0);

        public static async Task<int> SaveChangesAsync(this EntityDbContext connection)
            => await ExecuteSafeAsync(() => connection.SaveChangesAsync(), 0);

        // ---------- Transaction Operations ----------
        public static TResult ExecuteInTransaction<TResult>(this EntityDbContext connection, Func<TResult> operation, TResult defaultValue = default)
        {
            using var transaction = connection.Database.BeginTransaction();
            try
            {
                var result = operation();
                transaction.Commit();
                return result;
            }
            catch
            {
                transaction.Rollback();
                return defaultValue;
            }
        }

        public static async Task<TResult> ExecuteInTransactionAsync<TResult>(this EntityDbContext connection, Func<Task<TResult>> operation, TResult defaultValue = default)
        {
            using var transaction = await connection.Database.BeginTransactionAsync();
            try
            {
                var result = await operation();
                await transaction.CommitAsync();
                return result;
            }
            catch
            {
                await transaction.RollbackAsync();
                return defaultValue;
            }
        }

        // ---------- Bulk Operations ----------
        public static List<T> GetList<T>(this EntityDbContext connection, Expression<Func<T, bool>>? predicate = null) where T : class, IEntityBase
        {
            var query = connection.Table<T>();
            if (predicate != null)
                query = query.Where(predicate);
            
            return ExecuteSafe(() => query.ToList(), new List<T>());
        }

        public static async Task<List<T>> GetListAsync<T>(this EntityDbContext connection, Expression<Func<T, bool>>? predicate = null) where T : class, IEntityBase
        {
            var query = connection.Table<T>();
            if (predicate != null)
                query = query.Where(predicate);
            
            return await ExecuteSafeAsync(() => query.ToListAsync(), new List<T>());
        }

        public static IQueryable<T> GetPaged<T>(this EntityDbContext connection, int page, int pageSize, Expression<Func<T, bool>>? predicate = null) where T : class, IEntityBase
        {
            var query = connection.Table<T>();
            if (predicate != null)
                query = query.Where(predicate);
            
            return query.Skip((page - 1) * pageSize).Take(pageSize);
        }

        public static (List<T> Items, int TotalCount) GetPagedResult<T>(this EntityDbContext connection, int page, int pageSize, Expression<Func<T, bool>>? predicate = null) where T : class, IEntityBase
        {
            var query = connection.Table<T>();
            if (predicate != null)
                query = query.Where(predicate);
            
            var totalCount = ExecuteSafe(() => query.Count(), 0);
            var items = ExecuteSafe(() => query.Skip((page - 1) * pageSize).Take(pageSize).ToList(), new List<T>());
            
            return (items, totalCount);
        }

        public static async Task<(List<T> Items, int TotalCount)> GetPagedResultAsync<T>(this EntityDbContext connection, int page, int pageSize, Expression<Func<T, bool>>? predicate = null) where T : class, IEntityBase
        {
            var query = connection.Table<T>();
            if (predicate != null)
                query = query.Where(predicate);
            
            var totalCount = await ExecuteSafeAsync(() => query.CountAsync(), 0);
            var items = await ExecuteSafeAsync(() => query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync(), new List<T>());
            
            return (items, totalCount);
        }
    }
}