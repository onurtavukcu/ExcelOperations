using ExcelOperations.Commands;
using ExcelOperations.Context;
using ExcelOperations.Repository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExcelOperations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsertDataToDbController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        public InsertDataToDbController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        [HttpGet]
        [Route("InsertAllDataToDb")]
        public ActionResult Get(CancellationToken cancellationToken)
        {
            var insertInstance = new InsertAllDataToDbCommand(_uow.DbContext);

            var result = insertInstance.InsertDataAsync(cancellationToken);

            return Ok(result);
        }
    }
}
