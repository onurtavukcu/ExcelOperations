using ExcelOperations.Context;
using ExcelOperations.DocEntity;
using ExcelOperations.Operations;
using ExcelOperations.Operations.ExcelToFileModelOperations.Lager;
using ExcelOperations.Operations.ExcelToFileModelOperations.PO;
using ExcelOperations.Operations.ExcelToFileModelOperations.POC;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExcelOperations.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExcelOperationsEndPointsController : ControllerBase
    {
        private readonly EntityDbContext _EntityDbContext;

        public ExcelOperationsEndPointsController(EntityDbContext DbContext)
        {
            _EntityDbContext = DbContext;
        }

        [HttpGet]
        [Route("RouterAktuelAsync")]
        public async Task<IActionResult> RouterAktuellInsertAsync(CancellationToken cancellationToken)
        {
            var timer = new Stopwatch();
            timer.Start();

            var excelReader = new RouterAktuell_ExcelFileToModels();

            var result = await excelReader.RouterAktuellAsync(cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result,cancellationToken);

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

            var excelReader = new RouterSwapAktuell_ExcelFileToModels();

            var result = await excelReader.RouterSwapAktuellAsync(cancellationToken);

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
            
            var excelReader = new XWDMAktuel_ExcelFileToModels();

            var result = await excelReader.XWDMAktuellAsync(cancellationToken);

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

            var excelReader = new ZugangsdatenAktuell_ExcelFileToModel();

            var result = await excelReader.ZugangsdatenAktuellAsync(cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result,cancellationToken);

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

            var excelReader = new Deltatel_ExcelFileToModels();

            var result = await excelReader.DeltatelPOAsync(cancellationToken);

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

            var excelReader = new ZTE_ExcelFileToModels();

            var result = await excelReader.ZTEPOAsync(cancellationToken);

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

            var excelReader = new Cisco_ExcelFileToModels();

            var result = await excelReader.CiscoPOAsync(cancellationToken);

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

            var excelReader = new Lagers_ExcelFileToModels();

            var result = await excelReader.LagerAsync(cancellationToken);

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

            var excelReader = new MultiProject_ExcelFileToModels();

            var result = await excelReader.MultiProjectAsync(cancellationToken);

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

            var excelReader = new JSLMultiProject_ExcelFileToModels();

            var result = await excelReader.JSLMultiProjectAsync(cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result, cancellationToken);

            timer.Stop();

            Console.Write("Lager Elapsed Time : " + timer.ElapsedMilliseconds);

            return Ok();
        }

        [HttpPost(Name = "SetTest")]
        public IActionResult Set([FromBody] RouterAktuell routerAktuell)
        {
            _EntityDbContext.Add(routerAktuell);

            _EntityDbContext.SaveChanges();

            return Ok("gral");

        }
    }
}