namespace ExcelOperations.Context
{
    public class CheckTableExist
    {
        private readonly EntityDbContext _context;
        public CheckTableExist(EntityDbContext context)
        {
            _context = context;
        }

        public bool CheckDbAndTables()
        {
            var tableExist = CheckTable();
            if (tableExist == false)
            {
                return false;
            }
            return true;
        }

        public bool CheckTable()
        {
            var c4 = _context.Cisco_POs.Where(t => t.Objekt_ID == null).Select(k => k.Objekt_ID);
            var c1 = _context.RouterAktuell.Where(t => t.Projekt_ID == null).Select(k => k.Projekt_ID);
            var c2 = _context.RouterSwapAktuells;
            var c3 = _context.ZugangsdatenAktuells;
            var c5 = _context.Deltatel_POs;
            var c6 = _context.ZTE_POs;
            var c7 = _context.LagerCentrals;
            var c8 = _context.XWDMAktuells;
            var c9 = _context.MultiProjects;
            var c10 = _context.JSLMultiProjects;
            var c11 = _context.RouterAktuellOrderLists;
            var c12 = _context.XWDMAktuelOrderLists;

           

            if (
                c1 == null ||
                c2 == null ||
                c3 == null || 
                c4 == null ||
                c5 == null ||
                c6 == null || 
                c7 == null ||
                c8 == null ||
                c9 == null ||
                c10 == null ||
                c11 == null ||
                c12 == null
                )
            {
                return false;
            }
            return true;
        }
    }

    //public async void CreateDatabaseAndInsertAllData()
    //{
    //    CancellationToken cancellationToken = default(CancellationToken);
    //    _DbContext.Database.EnsureDeleted();
    //    _DbContext.Database.EnsureCreated();
    //    var fetchAllData = new InsertAllDataToDb(_DbContext);
    //    await fetchAllData.InsertDataAsync(cancellationToken);

    //    //_DbContext.Database.GenerateCreateScript
    //}

}
