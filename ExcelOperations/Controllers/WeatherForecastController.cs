using ExcelOperations.Context;
using ExcelOperations.DocEntity;
using ExcelOperations.Operations;
using Microsoft.AspNetCore.Mvc;

namespace ExcelOperations.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly EntityDbContext _routerAktuellDbContext;

        public WeatherForecastController(EntityDbContext routerAktuellDbContext)
        {
            _routerAktuellDbContext = routerAktuellDbContext;
        }

        [HttpGet(Name = "RouterAktuell")]
        public IActionResult GetRouterAktuell()
        {
            var excelReader = new RouterAktuell_ExcelFileToModels();

            var result = excelReader.ExcelTables();

            foreach (var item in result)
            {
                _routerAktuellDbContext.Add(item);
                _routerAktuellDbContext.SaveChanges();
            }

            return Ok();
        }

        [HttpGet(Name = "RouterSwapAktuel")]
        public IActionResult GetRouterSwapAktuel()
        {
            var excelReader = new RouterSwapAktuell_ExcelFileToModels();

            var result = excelReader.ExcelTables();

            foreach (var item in result)
            {
                _routerAktuellDbContext.Add(item);
                _routerAktuellDbContext.SaveChanges();
            }

            return Ok();
        }

        [HttpPost(Name = "SetTest")]

        public IActionResult Set([FromBody] RouterAktuell routerAktuell)
        {
            _routerAktuellDbContext.Add(routerAktuell);

            _routerAktuellDbContext.SaveChanges();

            return Ok("gral");

        }
    }
}