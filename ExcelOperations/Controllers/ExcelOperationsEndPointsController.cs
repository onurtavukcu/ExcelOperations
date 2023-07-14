using ExcelOperations.Context;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ExcelOperations.Commands;
using AutoMapper;
using ExcelOperations.Entities.DocEntityDTO.POCDTO;
using Microsoft.EntityFrameworkCore;
using ExcelOperations.Entities.DocEntityDTO.AktuellDTO;
using ExcelOperations.Entities.DocEntityDTO.PODTO;
using ExcelOperations.DocEntity.UserInfo;

namespace ExcelOperations.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExcelOperationsEndPointsController : ControllerBase
    {
        private readonly EntityDbContext _EntityDbContext;

        private readonly IMapper _mapper;
        
        public ExcelOperationsEndPointsController(EntityDbContext DbContext, IMapper mapper)
        {
            _EntityDbContext = DbContext;

            _mapper = mapper;
        }
        //[Authorize]
        [HttpGet]
        [Route("InsertAllDataToDb")]
        public async Task<IActionResult> GetSomeDataFromDB(CancellationToken cancellationToken)
        {
            var timer = new Stopwatch();

            timer.Start();

            var fetchAllData = new InsertAllDataToDbCommand(_EntityDbContext);

            await fetchAllData.InsertDataAsync(cancellationToken);

            timer.Stop();

            Console.Write("Lager Elapsed Time : " + timer.Elapsed.TotalSeconds);

            return Ok();
        }
       
        [HttpGet]
        [Route("GetSomeDataV2")]
        public IActionResult GetSomeDataFromDBV2()
        {
            var result = _EntityDbContext.MultiProjects.Where(p => p.NE_Nr == "203792153");

            return Ok(_mapper.Map<IEnumerable<MultiProjectDTO>>(result)); // return only MultiProjectDTODTO's column
        }

        [HttpGet]
        [Route("GetSomeDataV3")]
        public IActionResult GetSomeDataFromDBV3()
        {
            var result = _EntityDbContext.Deltatel_POs.Where(p => p.PR_NO == "3611248906");

            return Ok(_mapper.Map<IEnumerable<Deltatel_PODTO>>(result)); // return only MultiProjectDTODTO's column
        }


        [HttpGet]
        [Route("GetSomeDataV4")]
        public IActionResult GetSomeDataFromDBV4()
        {
            var result = _EntityDbContext.RouterAktuell.Where(p => p.Ort == "Hamburg");

            return Ok(_mapper.Map<IEnumerable<RouterAktuellDTO>>(result)); // return only MultiProjectDTODTO's column
        }


        [HttpGet]
        [Route("GetSomeDataV5")]
        public IActionResult GetSomeDataFromDBV5()
        {
            var result = _EntityDbContext.XWDMAktuells.Where(p => p.Projektart == "Aufbau");

            return Ok(_mapper.Map<IEnumerable<XWDMAktuellDTO>>(result)); // return only MultiProjectDTODTO's column
        }

        [HttpPost]
        [Route("Authenticate")]
        public IActionResult AuthenticateUser(UserInput userInput)
        {
            var result = _EntityDbContext.UserInputs  //now only one user check
                .Any(
                p => p.UserName == userInput.UserName &&
                p.Password == userInput.Password
                );

            ArgumentNullException.ThrowIfNull(result);


            if (result)
            {
                return Ok();
            }
            else
            {
                return Unauthorized();
            }

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
        //[Route("JoinTables")]
        //public async void JoinTables(CancellationToken cancellationToken)
        //{
        //    Type interfaceType = typeof(IEntityBase);

        //    // Get all loaded assemblies in the current application domain
        //    Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();

        //    foreach (Assembly assembly1 in assemblies)
        //    {
        //        // Get all types defined in the assembly
        //        Type[] types1 = assembly1.GetTypes();

        //        foreach (Type type in types1)
        //        {
        //            // Check if the type implements the interface
        //            if (interfaceType.IsAssignableFrom(type))
        //            {
        //                Console.WriteLine($"{type.Name} implements the interface.");
        //            }
        //        }
        //    }
        //}


        [HttpGet]
        [Route("RelatedQuery")]
        public async Task<IActionResult> RelatedQuery(CancellationToken cancellationToken)
        {
            var timer = new Stopwatch();

            timer.Start();

            var result = _EntityDbContext.RouterAktuell
                .Include(t1 => t1.Projekt_ID)
                .Include(t2 => t2.SAT)
                .ToList()
                .Select(res => new RouterAktuellDTO
                {
                    Projekt_ID = res.Projekt_ID
                });

            timer.Stop();

            Console.Write("DeltatelPO Elapsed Time : " + timer.ElapsedMilliseconds);

            return Ok(result);
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