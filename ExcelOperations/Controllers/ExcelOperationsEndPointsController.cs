using ExcelOperations.Context;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ExcelOperations.Commands;
using AutoMapper;
using ExcelOperations.Entities.DocEntityDTO.POCDTO;
using ExcelOperations.Repositories;

namespace ExcelOperations.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExcelOperationsEndPointsController : ControllerBase
    {
        private readonly EntityDbContext _EntityDbContext;

        private readonly IMapper _mapper;

        //public CheckDbTableExistance checkDbTableExistance => new CheckDbTableExistance(_EntityDbContext);

        public ExcelOperationsEndPointsController(EntityDbContext DbContext, IMapper mapper)
        {
            _EntityDbContext = DbContext;

            _mapper = mapper;
        }

        [HttpGet]
        [Route("InsertAllDataToDb")]
        public async Task<IActionResult> GetSomeDataFromDB(CancellationToken cancellationToken)
        {
            var timer = new Stopwatch();
            timer.Start();

            var fetchAllData = new InsertAllDataToDb(_EntityDbContext);

            await fetchAllData.InsertDataAsync(cancellationToken);

            timer.Stop();

            Console.Write("Lager Elapsed Time : " + timer.Elapsed.TotalSeconds);

            return Ok();
        }

        [HttpGet]
        [Route("GetSomeDataV2")]
        public IActionResult GetSomeDataFromDBV3()
        {
            var timer = new Stopwatch();
            timer.Start();

            var lagerRepo = new MultiProjectRepositories(_EntityDbContext);

            var result = lagerRepo.GetMultiProject();

            var testdto = _mapper.Map<IEnumerable<MultiProjectDTO>>(result);

            timer.Stop();
            Console.Write("With DTO Time : " + timer.Elapsed.TotalSeconds);

            return Ok(testdto);
        }

        //[HttpGet]
        //[Route("JoinTables")]
        //public async Task<IActionResult> JoinTables(CancellationToken cancellationToken)
        //{
        //    var timer = new Stopwatch();

        //    timer.Start();

        //    var result = _EntityDbContext.Deltatel_POs.Where(i => i.PR_NO == "3611248906");

        //    var posresult = new EachPosOrder(_EntityDbContext);

        //    var result1 = posresult.DeltatelOrders();

        //    timer.Stop();

        //    Console.Write("DeltatelPO Elapsed Time : " + timer.ElapsedMilliseconds);

        //    return Ok(result);
        //}


        //[HttpGet]
        //[Route("RelatedQuery")]
        //public async Task<IActionResult> RelatedQuery(CancellationToken cancellationToken)
        //{
        //    var timer = new Stopwatch();

        //    timer.Start();

        //    var results = _EntityDbContext.LagerCentrals
        //        .Include(t1 => t1.)
        //        .Include(t2 => t2.)
        //        .Where(t1 => t1.ProjectId == "123")
        //        .ToList();



        //    timer.Stop();

        //    Console.Write("DeltatelPO Elapsed Time : " + timer.ElapsedMilliseconds);

        //    return Ok(result);
        //}




        //[HttpPost(Name = "SetTest")]
        //public IActionResult Set([FromBody] RouterAktuell routerAktuell)
        //{
        //    _EntityDbContext.Add(routerAktuell);

        //    _EntityDbContext.SaveChanges();

        //    return Ok("gral");

        //}
    }
}