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

        private readonly RouterAktuellDbContext _routerAktuellDbContext;

        public WeatherForecastController(RouterAktuellDbContext routerAktuellDbContext)
        {
            _routerAktuellDbContext = routerAktuellDbContext;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
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

        [HttpPost(Name = "SetTest")]

        public IActionResult Set([FromBody] RouterAktuell routerAktuell)
        {
            _routerAktuellDbContext.Add(routerAktuell);

            _routerAktuellDbContext.SaveChanges();

            return Ok("gral");

        }
    }
}