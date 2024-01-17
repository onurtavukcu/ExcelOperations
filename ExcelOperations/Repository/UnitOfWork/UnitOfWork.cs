using ExcelOperations.Context;
using ExcelOperations.Repository.ModelRepository.CiscoPoRepository;
using ExcelOperations.Repository.ModelRepository.DeltatelPORepository;
using ExcelOperations.Repository.ModelRepository.JSLMultiPorjectRepository;
using ExcelOperations.Repository.ModelRepository.LagerCentralRepository;
using ExcelOperations.Repository.ModelRepository.MultiProjectRepository;
using ExcelOperations.Repository.ModelRepository.ProjectIdMappingRepository;
using ExcelOperations.Repository.ModelRepository.RouterAktuellOrderListRepository;
using ExcelOperations.Repository.ModelRepository.RouterAktuellRepository;
using ExcelOperations.Repository.ModelRepository.RouterSwapAktuellRepository;
using ExcelOperations.Repository.ModelRepository.SONRMappingRepository;
using ExcelOperations.Repository.ModelRepository.UserRepository;
using ExcelOperations.Repository.ModelRepository.XWDMAktuellOrderListRepository;
using ExcelOperations.Repository.ModelRepository.XWDMAktuellRepository;
using ExcelOperations.Repository.ModelRepository.ZTEPORepository;
using ExcelOperations.Repository.ModelRepository.ZuganssdatenAktuellRepository;

namespace ExcelOperations.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EntityDbContext _dbContext;
        public UnitOfWork(EntityDbContext dbContext)
        {
            _dbContext = dbContext;
            CiscoPoRepository = new CiscoPoRepository(_dbContext);
            DeltatelPORepository = new DeltatelPORepository(_dbContext);
            JSLMultiPorjectRepository = new JSLMultiPorjectRepository(_dbContext);
            LagerCentralRepository = new LagerCentralRepository(_dbContext);
            MultiProjectRepository = new MultiProjectRepository(_dbContext);
            RouterAktuellOrderListRepository = new RouterAktuellOrderListRepository(_dbContext);
            RouterAktuellRepository = new RouterAktuellRepository(_dbContext);
            RouterSwapAktuellRepository = new RouterSwapAktuellRepository(dbContext);
            UserRepository = new UserRepository(_dbContext);
            XWDMAktuellOrderListRepository = new XWDMAktuellOrderListRepository(dbContext);
            XWDMAktuellRepository = new XWDMAktuellRepository(dbContext);
            ZTEPORepository = new ZTEPORepository(dbContext);
            ZuganssdatenAktuellRepository = new ZuganssdatenAktuellRepository(dbContext);
        }

        public EntityDbContext DbContext => _dbContext;
        public ICiscoPoRepository CiscoPoRepository { get; set; }
        public IDeltatelPORepository DeltatelPORepository { get; set; }
        public IJSLMultiPorjectRepository JSLMultiPorjectRepository { get; set; }
        public ILagerCentralRepository LagerCentralRepository { get; set; }
        public IMultiProjectRepository MultiProjectRepository { get; set; }
        public IRouterAktuellOrderListRepository RouterAktuellOrderListRepository { get; set; }
        public IRouterAktuellRepository RouterAktuellRepository { get; set; }
        public IRouterSwapAktuellRepository RouterSwapAktuellRepository { get; set; }
        public IUserRepository UserRepository { get; set; }
        public IXWDMAktuellOrderListRepository XWDMAktuellOrderListRepository { get; set; }
        public IXWDMAktuellRepository XWDMAktuellRepository { get; set; }
        public IZTEPORepository ZTEPORepository { get; private set; }
        public IZuganssdatenAktuellRepository ZuganssdatenAktuellRepository { get; private set; }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }
    }
}
