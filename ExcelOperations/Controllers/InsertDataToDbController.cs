using ExcelOperations.Commands;
using ExcelOperations.Context;
using ExcelOperations.Repository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;


namespace ExcelOperations.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InsertDataToDbController : ControllerBase
    {
        private readonly IUnitOfWork _uow;

        public InsertDataToDbController(IUnitOfWork uow, EntityDbContext dbContext)
        {
            _uow = uow;
        }

        [HttpGet]
        [Route("InsertAllDataToDb")]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            //var insertInstance = new InsertAllDataToDbCommand(_uow);

            //var result = insertInstance.InsertDataAsync(cancellationToken,);

            //return await Task.FromResult<IActionResult>(Ok(result));

            var insertInstance = new InsertAllDataToDbCommand(_uow);

            await insertInstance.InsertDataAsync(cancellationToken);

            return await Task.FromResult<IActionResult>(Ok());
        }
    }
}
