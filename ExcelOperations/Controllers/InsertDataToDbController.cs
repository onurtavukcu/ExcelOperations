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
        private readonly IUnitOfWork _unitOfWork;

        public InsertDataToDbController(IUnitOfWork unitOfWork, EntityDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("InsertAllDataToDb")]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            var insertInstance = new InsertAllDataToDbCommand(_unitOfWork);

            await insertInstance.InsertDataAsync(cancellationToken);

            return await Task.FromResult<IActionResult>(Ok());
        }
    }
}
