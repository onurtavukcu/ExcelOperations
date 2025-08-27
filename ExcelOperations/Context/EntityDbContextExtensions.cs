using Microsoft.EntityFrameworkCore;
using ExcelOperations.Entities;
using System.Linq.Expressions;

namespace ExcelOperations.Context
{
    public static class EntityDbContextExtensions
    {
        // Generic table accessor
        private static IQueryable<T> Table<T>(this EntityDbContext connection) where T : class, IEntityBase
            => connection.Set<T>();

        // Safe execution wrapper for operations that might throw exceptions
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

        // Async version of ExecuteSafe
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

        // ---------- Basic CRUD Operations ----------

        /// <summary>
        /// Gets all entities of type T
        /// </summary>
        public static IQueryable<T> GetAll<T>(this EntityDbContext context) where T : class, IEntityBase
        {
            return context.Table<T>();
        }

        /// <summary>
        /// Gets entity by ID safely
        /// </summary>
        public static T? GetById<T>(this EntityDbContext context, int id) where T : class, IEntityBase
        {
            return ExecuteSafe(() => context.Table<T>().FirstOrDefault(x => x.id == id));
        }

        /// <summary>
        /// Gets entity by ID asynchronously
        /// </summary>
        public static async Task<T?> GetByIdAsync<T>(this EntityDbContext context, int id) where T : class, IEntityBase
        {
            return await ExecuteSafeAsync(() => context.Table<T>().FirstOrDefaultAsync(x => x.id == id));
        }

        /// <summary>
        /// Finds entities by predicate safely
        /// </summary>
        public static IQueryable<T> Find<T>(this EntityDbContext context, Expression<Func<T, bool>> predicate) where T : class, IEntityBase
        {
            return ExecuteSafe(() => context.Table<T>().Where(predicate), context.Set<T>().Take(0));
        }

        /// <summary>
        /// Gets first entity matching predicate safely
        /// </summary>
        public static T? FirstOrDefault<T>(this EntityDbContext context, Expression<Func<T, bool>> predicate) where T : class, IEntityBase
        {
            return ExecuteSafe(() => context.Table<T>().FirstOrDefault(predicate));
        }

        /// <summary>
        /// Gets first entity matching predicate asynchronously
        /// </summary>
        public static async Task<T?> FirstOrDefaultAsync<T>(this EntityDbContext context, Expression<Func<T, bool>> predicate) where T : class, IEntityBase
        {
            return await ExecuteSafeAsync(() => context.Table<T>().FirstOrDefaultAsync(predicate));
        }

        /// <summary>
        /// Checks if any entity matches the predicate
        /// </summary>
        public static bool Any<T>(this EntityDbContext context, Expression<Func<T, bool>> predicate) where T : class, IEntityBase
        {
            return ExecuteSafe(() => context.Table<T>().Any(predicate), false);
        }

        /// <summary>
        /// Checks if any entity matches the predicate asynchronously
        /// </summary>
        public static async Task<bool> AnyAsync<T>(this EntityDbContext context, Expression<Func<T, bool>> predicate) where T : class, IEntityBase
        {
            return await ExecuteSafeAsync(() => context.Table<T>().AnyAsync(predicate), false);
        }

        /// <summary>
        /// Counts entities matching predicate
        /// </summary>
        public static int Count<T>(this EntityDbContext context, Expression<Func<T, bool>>? predicate = null) where T : class, IEntityBase
        {
            return ExecuteSafe(() => predicate == null 
                ? context.Table<T>().Count() 
                : context.Table<T>().Count(predicate), 0);
        }

        /// <summary>
        /// Counts entities matching predicate asynchronously
        /// </summary>
        public static async Task<int> CountAsync<T>(this EntityDbContext context, Expression<Func<T, bool>>? predicate = null) where T : class, IEntityBase
        {
            return await ExecuteSafeAsync(() => predicate == null 
                ? context.Table<T>().CountAsync() 
                : context.Table<T>().CountAsync(predicate), 0);
        }

        // ---------- Insert Operations ----------

        /// <summary>
        /// Adds a new entity
        /// </summary>
        public static T Add<T>(this EntityDbContext context, T entity) where T : class, IEntityBase
        {
            return ExecuteSafe(() => context.Set<T>().Add(entity).Entity, entity);
        }

        /// <summary>
        /// Adds multiple entities
        /// </summary>
        public static void AddRange<T>(this EntityDbContext context, IEnumerable<T> entities) where T : class, IEntityBase
        {
            ExecuteSafe(() => { context.Set<T>().AddRange(entities); return true; });
        }

        /// <summary>
        /// Adds entity and saves changes
        /// </summary>
        public static T AddAndSave<T>(this EntityDbContext context, T entity) where T : class, IEntityBase
        {
            return ExecuteSafe(() =>
            {
                var added = context.Set<T>().Add(entity).Entity;
                context.SaveChanges();
                return added;
            }, entity);
        }

        /// <summary>
        /// Adds entity and saves changes asynchronously
        /// </summary>
        public static async Task<T> AddAndSaveAsync<T>(this EntityDbContext context, T entity) where T : class, IEntityBase
        {
            return await ExecuteSafeAsync(async () =>
            {
                var added = context.Set<T>().Add(entity).Entity;
                await context.SaveChangesAsync();
                return added;
            }, entity);
        }

        // ---------- Update Operations ----------

        /// <summary>
        /// Updates an entity
        /// </summary>
        public static T Update<T>(this EntityDbContext context, T entity) where T : class, IEntityBase
        {
            return ExecuteSafe(() => context.Set<T>().Update(entity).Entity, entity);
        }

        /// <summary>
        /// Updates entity and saves changes
        /// </summary>
        public static T UpdateAndSave<T>(this EntityDbContext context, T entity) where T : class, IEntityBase
        {
            return ExecuteSafe(() =>
            {
                var updated = context.Set<T>().Update(entity).Entity;
                context.SaveChanges();
                return updated;
            }, entity);
        }

        /// <summary>
        /// Updates entity and saves changes asynchronously
        /// </summary>
        public static async Task<T> UpdateAndSaveAsync<T>(this EntityDbContext context, T entity) where T : class, IEntityBase
        {
            return await ExecuteSafeAsync(async () =>
            {
                var updated = context.Set<T>().Update(entity).Entity;
                await context.SaveChangesAsync();
                return updated;
            }, entity);
        }

        // ---------- Delete Operations ----------

        /// <summary>
        /// Removes an entity
        /// </summary>
        public static void Remove<T>(this EntityDbContext context, T entity) where T : class, IEntityBase
        {
            ExecuteSafe(() => { context.Set<T>().Remove(entity); return true; });
        }

        /// <summary>
        /// Removes entity by ID
        /// </summary>
        public static bool RemoveById<T>(this EntityDbContext context, int id) where T : class, IEntityBase
        {
            return ExecuteSafe(() =>
            {
                var entity = context.Table<T>().FirstOrDefault(x => x.id == id);
                if (entity != null)
                {
                    context.Set<T>().Remove(entity);
                    return true;
                }
                return false;
            }, false);
        }

        /// <summary>
        /// Removes entity by ID and saves changes
        /// </summary>
        public static bool RemoveByIdAndSave<T>(this EntityDbContext context, int id) where T : class, IEntityBase
        {
            return ExecuteSafe(() =>
            {
                var entity = context.Table<T>().FirstOrDefault(x => x.id == id);
                if (entity != null)
                {
                    context.Set<T>().Remove(entity);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }, false);
        }

        /// <summary>
        /// Removes entity by ID and saves changes asynchronously
        /// </summary>
        public static async Task<bool> RemoveByIdAndSaveAsync<T>(this EntityDbContext context, int id) where T : class, IEntityBase
        {
            return await ExecuteSafeAsync(async () =>
            {
                var entity = await context.Table<T>().FirstOrDefaultAsync(x => x.id == id);
                if (entity != null)
                {
                    context.Set<T>().Remove(entity);
                    await context.SaveChangesAsync();
                    return true;
                }
                return false;
            }, false);
        }

        // ---------- Bulk Operations ----------

        /// <summary>
        /// Gets entities with pagination
        /// </summary>
        public static IQueryable<T> GetPaged<T>(this EntityDbContext context, int page, int pageSize) where T : class, IEntityBase
        {
            return ExecuteSafe(() => context.Table<T>()
                .Skip((page - 1) * pageSize)
                .Take(pageSize), context.Set<T>().Take(0));
        }

        /// <summary>
        /// Gets entities with pagination and predicate
        /// </summary>
        public static IQueryable<T> GetPaged<T>(this EntityDbContext context, Expression<Func<T, bool>> predicate, int page, int pageSize) where T : class, IEntityBase
        {
            return ExecuteSafe(() => context.Table<T>()
                .Where(predicate)
                .Skip((page - 1) * pageSize)
                .Take(pageSize), context.Set<T>().Take(0));
        }

        /// <summary>
        /// Executes raw SQL query safely
        /// </summary>
        public static IQueryable<T> FromSqlRaw<T>(this EntityDbContext context, string sql, params object[] parameters) where T : class, IEntityBase
        {
            return ExecuteSafe(() => context.Set<T>().FromSqlRaw(sql, parameters), context.Set<T>().Take(0));
        }

        /// <summary>
        /// Saves changes safely
        /// </summary>
        public static int SaveChangesSafe(this EntityDbContext context)
        {
            return ExecuteSafe(() => context.SaveChanges(), 0);
        }

        /// <summary>
        /// Saves changes safely asynchronously
        /// </summary>
        public static async Task<int> SaveChangesSafeAsync(this EntityDbContext context)
        {
            return await ExecuteSafeAsync(() => context.SaveChangesAsync(), 0);
        }
    }
}