using ExcelOperations.Context;
using ExcelOperations.DocEntity;
using ExcelOperations.Operations;
using Microsoft.AspNetCore.Mvc;

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
        [Route("XWDMAktuell")]
        public IActionResult XWDMAktuell()
        {
            var excelReader = new XWDMAktuel_ExcelFileToModels();

            var result = excelReader.ExcelTables();

            foreach (var item in result)
            {
                _EntityDbContext.Add(item);
                _EntityDbContext.SaveChanges();
            }

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