using ExcelOperations.Context;
using ExcelOperations.Repository.ModelRepository.CiscoPoRepository;
using ExcelOperations.Repository.ModelRepository.DeltatelPORepository;
using ExcelOperations.Repository.ModelRepository.JSLMultiPorjectRepository;
using ExcelOperations.Repository.ModelRepository.LagerCentralRepository;
using ExcelOperations.Repository.ModelRepository.MultiProjectRepository;
using ExcelOperations.Repository.ModelRepository.RouterAktuellOrderListRepository;
using ExcelOperations.Repository.ModelRepository.RouterAktuellRepository;
using ExcelOperations.Repository.ModelRepository.RouterSwapAktuellRepository;
using ExcelOperations.Repository.ModelRepository.UserRepository;
using ExcelOperations.Repository.ModelRepository.XWDMAktuellOrderListRepository;
using ExcelOperations.Repository.ModelRepository.XWDMAktuellRepository;
using ExcelOperations.Repository.ModelRepository.ZTEPORepository;
using ExcelOperations.Repository.ModelRepository.ZuganssdatenAktuellRepository;
using Microsoft.EntityFrameworkCore;

namespace ExcelOperations.Repository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        EntityDbContext DbContext { get; }
        ICiscoPoRepository CiscoPoRepository { get; }
        IDeltatelPORepository DeltatelPORepository { get; }
        IJSLMultiPorjectRepository JSLMultiPorjectRepository { get; }
        ILagerCentralRepository LagerCentralRepository { get; }
        IMultiProjectRepository MultiProjectRepository { get; }
        IRouterAktuellOrderListRepository RouterAktuellOrderListRepository { get; }
        IRouterAktuellRepository RouterAktuellRepository { get; }
        IRouterSwapAktuellRepository RouterSwapAktuellRepository { get; }
        IUserRepository UserRepository { get; }
        IXWDMAktuellOrderListRepository XWDMAktuellOrderListRepository { get; }
        IXWDMAktuellRepository XWDMAktuellRepository { get; }
        IZTEPORepository ZTEPORepository { get; }
        IZuganssdatenAktuellRepository ZuganssdatenAktuellRepository { get; }
        int Save();
    }
}
