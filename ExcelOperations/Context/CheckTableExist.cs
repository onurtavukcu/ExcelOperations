using ExcelOperations.Commands;
using Microsoft.EntityFrameworkCore;

namespace ExcelOperations.Context
{
    public class CheckTableExist
    {
        private readonly EntityDbContext _context;
        public CheckTableExist(EntityDbContext context)
        {
            _context = context;
        }
        
        public void checkAllTable()
        {
            _context.Entry(CheckTableInDatabase<EntityDbContext>);
        }
        public bool CheckTableInDatabase<T>() where T : class
        {
            try
            {
                _context.Set<T>().Count();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    public class CheckDbTableExistance
    {
        private readonly EntityDbContext _DbContext;
        public CheckDbTableExistance(EntityDbContext _EntityDbContext)
        {
            _DbContext = _EntityDbContext;
        }
        public int CheckTable()
        {
            try
            {
                return _DbContext.Database.ExecuteSql($@"Select cp.id from ""Cisco_POs"" cp where id < 2");
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public async void CreateDatabaseAndInsertAllData()
        {
            CancellationToken cancellationToken = default(CancellationToken);
            _DbContext.Database.EnsureDeleted();
            _DbContext.Database.EnsureCreated();
            var fetchAllData = new InsertAllDataToDb(_DbContext);
            await fetchAllData.InsertDataAsync(cancellationToken);

            //_DbContext.Database.GenerateCreateScript
        }
    }
}
