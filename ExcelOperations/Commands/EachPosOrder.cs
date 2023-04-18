using ExcelOperations.Context;
using ExcelOperations.DocEntity;
using ExcelOperations.DocEntity.Entity.PO;
using NuGet.Protocol;
using System.Collections;

namespace ExcelOperations.Commands
{
    public class EachPosOrder
    {
        public readonly EntityDbContext _EntityDbContext;
        public EachPosOrder(EntityDbContext entityDbContext)
        {
            _EntityDbContext = entityDbContext;
        }

        public async Task<IEnumerable<ZTE_PO>> DeltatelOrders()
        {
            //return await _EntityDbContext.Deltatel_POs.();


            return from ztePo in _EntityDbContext.ZTE_POs
                   where ztePo.Cabinet == "OK"
                   select ztePo;
            

            //return from lager in _EntityDbContext.LagerCentrals
            //             join delta in _EntityDbContext.Deltatel_POs on lager.PID equals delta.Site_Code
            //             join routAkt in _EntityDbContext.RouterAktuell on lager.PID equals routAkt.Projekt_ID
            //             join routAktOrder in _EntityDbContext.RouterAktuellOrderLists on lager.PID equals routAktOrder.Projekt_ID
            //             join XWDMAkt in _EntityDbContext.XWDMAktuells on lager.PID equals XWDMAkt.Projekt_ID
            //             join XWDMAktOder in _EntityDbContext.XWDMAktuelOrderLists on lager.PID equals XWDMAktOder.Projekt_ID
            //             join RouterSwap in _EntityDbContext.RouterSwapAktuells on lager.PID equals RouterSwap.Projekt_ID
            //             join pocMultiJsl in _EntityDbContext.JSLMultiProjects on lager.PID equals pocMultiJsl.Objekt_ID
            //             join pocMulti in _EntityDbContext.MultiProjects on lager.PID equals pocMulti.Objekt_ID
            //             join zugang in _EntityDbContext.ZugangsdatenAktuells on lager.SO_Nr equals zugang.SO_Nr
            //             select new
            //             {
            //                 lager,
            //                 delta,
            //                 routAkt,
            //                 routAktOrder,
            //                 XWDMAkt,
            //                 XWDMAktOder,
            //                 RouterSwap,
            //                 pocMultiJsl,
            //                 pocMulti,
            //                 zugang
            //             }.ToJson(Newtonsoft.Json.Formatting.None);

            //var result = tables.SelectMany(t => t.pocMulti.)
        }
    }
}
