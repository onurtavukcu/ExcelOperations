using ExcelOperations.Context;
using ExcelOperations.DocEntity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ExcelOperations.DocEntity.PO;
using ExcelOperations.DocEntity.Lager;
using ExcelOperations.Doc.Entity.POC;
using ExcelOperations.Operations.ExcelToFileModelOperations;
using ExcelOperations.DocEntity.Aktuell;

namespace ExcelOperations.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExcelOperationsEndPointsController : ControllerBase
    {
        private readonly EntityDbContext _EntityDbContext;

        //public CheckDbTableExistance checkDbTableExistance => new CheckDbTableExistance(_EntityDbContext);

        public ExcelOperationsEndPointsController(EntityDbContext DbContext)
        {
            _EntityDbContext = DbContext;

            //var existanceDb = checkDbTableExistance.CheckTable();

            //if (existanceDb < 1)
            //{
            //    Console.WriteLine("Missing DB or Table! Please Wait for Creating DB and Inserting All Data");
            //    //checkDbTableExistance.CreateDatabaseAndInsertAllData();
            //}
        }

        [HttpGet]
        [Route("RouterAktuelAsync")]
        public async Task<IActionResult> RouterAktuellInsertAsync(CancellationToken cancellationToken)
        {
            var timer = new Stopwatch();
            timer.Start();

            var reader = new ExcelFileToModelOps<RouterAktuell>();

            var result = await reader.GetDataFromExcelAsync(0, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result, cancellationToken);

            timer.Stop();

            Console.Write("Router Aktuell Elapsed Time : " + timer.ElapsedMilliseconds);

            return Ok();
        }

        [HttpGet]
        [Route("RouterSwapAktuelAsync")]
        public async Task<IActionResult> RouterSwapAktuelInsertAsync(CancellationToken cancellationToken)
        {
            var timer = new Stopwatch();
            timer.Start();

            var excelReader = new ExcelFileToModelOps<RouterSwapAktuell>();

            var result = await excelReader.GetDataFromExcelAsync(0, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result, cancellationToken);

            timer.Stop();

            Console.Write("Router Swap Aktuell Elapsed Time : " + timer.ElapsedMilliseconds);

            return Ok();
        }

        [HttpGet]
        [Route("XWDMAktuellAsync")]

        public async Task<IActionResult> XWDMAktuellInsertAsync(CancellationToken cancellationToken)
        {
            var timer = new Stopwatch();
            timer.Start();

            var excelReader = new ExcelFileToModelOps<XWDMAktuell>();

            var result = await excelReader.GetDataFromExcelAsync(0, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result, cancellationToken);

            timer.Stop();

            Console.Write("Router XWDM Aktuell Elapsed Time : " + timer.ElapsedMilliseconds);

            return Ok();
        }

        [HttpGet]
        [Route("ZugangsdatenAktuellAsync")]

        public async Task<IActionResult> ZugangsdatenAktuellInsertAsync(CancellationToken cancellationToken)
        {
            var timer = new Stopwatch();
            timer.Start();

            var excelReader = new ExcelFileToModelOps<ZugangsdatenAktuell>();

            var result = await excelReader.GetDataFromExcelAsync(0, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result, cancellationToken);

            timer.Stop();

            Console.Write("Zugangsdaten_aktuell Elapsed Time : " + timer.ElapsedMilliseconds);

            return Ok();
        }

        [HttpGet]
        [Route("DeltatelPOAsync")]

        public async Task<IActionResult> DeltatelPOInsertAsync(CancellationToken cancellationToken)
        {
            var timer = new Stopwatch();

            timer.Start();

            var excelReader = new ExcelFileToModelOps<Deltatel_PO>();

            var result = await excelReader.GetDataFromExcelAsync(0, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result, cancellationToken);

            timer.Stop();

            Console.Write("DeltatelPO Elapsed Time : " + timer.ElapsedMilliseconds);

            return Ok();
        }


        [HttpGet]
        [Route("ZTEPO_Async")]

        public async Task<IActionResult> ZTEPOInsertAsync(CancellationToken cancellationToken)
        {
            var timer = new Stopwatch();

            timer.Start();

            var excelReader = new ExcelFileToModelOps<ZTE_PO>();

            var result = await excelReader.GetDataFromExcelAsync(0, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result, cancellationToken);

            timer.Stop();

            Console.Write("ZTEPO Elapsed Time : " + timer.ElapsedMilliseconds);

            return Ok();
        }

        [HttpGet]
        [Route("CiscoPO_Async")]

        public async Task<IActionResult> CiscoPOInsertAsync(CancellationToken cancellationToken)
        {
            var timer = new Stopwatch();
            timer.Start();

            var excelReader = new ExcelFileToModelOps<Cisco_PO>();

            var result = await excelReader.GetDataFromExcelAsync(0, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result, cancellationToken);

            timer.Stop();

            Console.Write("Zugangsdaten_aktuell Elapsed Time : " + timer.ElapsedMilliseconds);

            return Ok();
        }

        [HttpGet]
        [Route("Depo_Async")]
        public async Task<IActionResult> DepoInsertAsync(CancellationToken cancellationToken)
        {
            var timer = new Stopwatch();
            timer.Start();

            var excelReader = new ExcelFileToModelOps<LagerCentral>();

            var result = await excelReader.GetDataFromExcelAsync(0, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result, cancellationToken);

            timer.Stop();

            Console.Write("Lager Elapsed Time : " + timer.ElapsedMilliseconds);

            return Ok();
        }

        [HttpGet]
        [Route("MultiProjectAsync")]
        public async Task<IActionResult> MultiProjectInsertAsync(CancellationToken cancellationToken)
        {
            var timer = new Stopwatch();
            timer.Start();

            var excelReader = new ExcelFileToModelOps<MultiProject>();

            var result = await excelReader.GetDataFromExcelAsync(0, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result, cancellationToken);

            timer.Stop();

            Console.Write("Lager Elapsed Time : " + timer.ElapsedMilliseconds);

            return Ok();
        }

        [HttpGet]
        [Route("JSLMultiProjectAsync")]
        public async Task<IActionResult> JSLMultiProjectInsertAsync(CancellationToken cancellationToken)
        {
            var timer = new Stopwatch();
            timer.Start();

            var excelReader = new ExcelFileToModelOps<JSLMultiProject>();

            var result = await excelReader.GetDataFromExcelAsync(0, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result, cancellationToken);

            timer.Stop();

            Console.Write("Lager Elapsed Time : " + timer.ElapsedMilliseconds);
            return Ok();
        }

        [HttpGet]
        [Route("RouterAktuellOrderList")]
        public async Task<IActionResult> RouterAktuellOrderListAsync(CancellationToken cancellationToken)
        {
            var timer = new Stopwatch();

            timer.Start();

            var excelReader = new ExcelFileToModelOps<RouterAktuellOrderList>();

            var result = await excelReader.GetDataFromExcelAsync(1, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result, cancellationToken);

            timer.Stop();

            Console.Write("DeltatelPO Elapsed Time : " + timer.ElapsedMilliseconds);

            return Ok();
        }

        [HttpGet]
        [Route("XWDMAktuellOrderList")]
        public async Task<IActionResult> XWDMAktuellOrderListAsync(CancellationToken cancellationToken)
        {
            var timer = new Stopwatch();

            timer.Start();

            var excelReader = new ExcelFileToModelOps<XWDMAktuellOrderList>();

            var result = await excelReader.GetDataFromExcelAsync(1, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result, cancellationToken);

            timer.Stop();

            Console.Write("DeltatelPO Elapsed Time : " + timer.ElapsedMilliseconds);

            return Ok();
        }



        //[HttpGet]
        //[Route("InsertAllDataToDb")]
        //public async Task<IActionResult> GetSomeDataFromDB(CancellationToken cancellationToken)
        //{
        //    var timer = new Stopwatch();
        //    timer.Start();

        //    var fetchAllData = new InsertAllDataToDb(_EntityDbContext);

        //    await fetchAllData.InsertDataAsync(cancellationToken);

        //    timer.Stop();

        //    Console.Write("Lager Elapsed Time : " + timer.Elapsed.TotalSeconds);

        //    return Ok();
        //}


        //[HttpGet]
        //[Route("GetSomeDataV2")]
        //public IActionResult GetSomeDataFromDBV2()
        //{
        //    var timer = new Stopwatch();
        //    timer.Start();

        //    var lager = _EntityDbContext.LagerCentrals;

        //    var pos = _EntityDbContext.ZTE_POs;

        //    var result = pos.SelectMany(posq =>
        //                                      lager.Where(
        //                                          lagerq => lagerq.PID == posq.Projekt_ID
        //                                          && posq.Projekt_ID == "701137334"));

        //    timer.Stop();

        //    Console.Write("Lager Elapsed Time : " + timer.Elapsed.TotalSeconds);

        //    return Ok(result);
        //}

        //[HttpGet]
        //[Route("TestGeneric")]
        //public async Task<IActionResult> TestGenerication(CancellationToken cancellationToken)
        //{
        //    var readers = new ExcelFileToModelOps<RouterAktuell>();

        //    var results = await readers.GetDataFromExcelAsync(cancellationToken);

        //    await _EntityDbContext.BulkInsertAsync(results, cancellationToken);

        //    return Ok(results);

        //}


        [HttpGet]
        [Route("TestCheckTable")]
        public bool TestGenerication()
        {
            var tables = new CheckTableExist(_EntityDbContext);

            var result = tables.CheckDbAndTables();

            return result;

        }




        //[HttpPost(Name = "SetTest")]
        //public IActionResult Set([FromBody] RouterAktuell routerAktuell)
        //{
        //    _EntityDbContext.Add(routerAktuell);

        //    _EntityDbContext.SaveChanges();

        //    return Ok("gral");

        //}
    }
}