using System.Linq.Expressions;

namespace ExcelOperations.Repository.Implementor
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        IQueryable<T> GetAll();
        IQueryable<T> GetByFilter(Expression<Func<T, bool>> filter);
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        void AddAsync(T entity);
        void AddRangeAsync(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        Task BulkSaveAsync(IEnumerable<object> entity, CancellationToken cancellationToken);
        int SaveEntity(T entity);
        //IQueryable<T> MySelect(Expression<Func<T, bool>> filter);
    }
}
// 1-  convert all ıenumarable to ıqueryable
// 2 - Sorgu sonucu sadece sorgulamaksa db'ye veri eklemk değilse AsNoTracking ile memoride tutmayı engelle. saveChanges'e başvurmaz
// 3 - Gerekmedikçe include kullanma. new ile al
// 4 - Pagination yap !!!! https://www.youtube.com/watch?v=dDANjr5MCew&ab_channel=NDCConferences
// 5 - Sorrgularda cancellation token kullan
// 6 - Update delete konusu olunca video'ya bak!
// 7 - 
//