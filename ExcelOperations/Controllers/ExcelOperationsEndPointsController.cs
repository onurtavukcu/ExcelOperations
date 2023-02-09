using ExcelOperations.Context;
using ExcelOperations.DocEntity;
using ExcelOperations.Operations;
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
        [Route("RouterAktuel")]
        public IActionResult RouterAktuell()
        {
            var excelReader = new RouterAktuell_ExcelFileToModels();

            var result = excelReader.ExcelTables();

            foreach (var item in result)
            {
                _EntityDbContext.Add(item);
                _EntityDbContext.SaveChanges();
            }

            return Ok();
        }

        [HttpGet]
        [Route("RouterSwapAktuel")]
        public IActionResult RouterSwapAktuel()
        {
            var excelReader = new RouterSwapAktuell_ExcelFileToModels();

            var result = excelReader.ExcelTables();

            foreach (var item in result)
            {
                _EntityDbContext.Add(item);
                _EntityDbContext.SaveChanges();
            }

            return Ok();
        }

        [HttpGet]
        [Route("XWDMAktuellAsync")]
        public async Task<IActionResult> XWDMAktuellAsync(CancellationToken cancellationToken)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var excelReader = new XWDMAktuel_ExcelFileToModels();

            var result = await excelReader.ExcelTablesAsync(cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result, cancellationToken);

            stopwatch.Stop();

            Console.WriteLine("ElapsedTime ASYNC" + stopwatch.Elapsed);
            return Ok();
        }

        [HttpGet]
        [Route("XWDMAktuell")]
        public IActionResult XWDMAktuell()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var excelReader = new XWDMAktuel_ExcelFileToModels();

            var result = excelReader.ExcelTables();

            _EntityDbContext.BulkInsert(result);

            stopwatch.Stop();

            Console.WriteLine("ElapsedTime" + stopwatch.Elapsed);
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