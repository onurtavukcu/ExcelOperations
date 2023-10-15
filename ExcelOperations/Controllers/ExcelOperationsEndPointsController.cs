using Microsoft.AspNetCore.Mvc;
using ExcelOperations.Repository.UnitOfWork;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using ExcelOperations.Entities.DocEntityDTO.POCDTO;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using ExcelOperations.Entities.DocEntityDTO.PODTO;
using Newtonsoft.Json;
using ExcelOperations.Operations.MinorOperations.CoordinateOperation;

namespace ExcelOperations.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExcelOperationsEndPointsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public ExcelOperationsEndPointsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize]
        public ActionResult Get()
        {
            var routerAktuell = _unitOfWork.LagerCentralRepository.GetAll();
            
            return Ok(routerAktuell);

        }

        //[HttpGet]
        //[Route("InsertAllDataToDb")]
        //public async Task<IActionResult> GetSomeDataFromDB(CancellationToken cancellationToken)
        //{
        //    var test = (EntityDbContext)_unitOfWork();


        //    return Ok();
        //}

        [HttpGet]
        [Route("GetSomeDataV2")]
        public IActionResult GetSomeDataFromDBV2(CancellationToken cancellationToken)
        {
            var timer1 = new Stopwatch();
            timer1.Start();

            var result = _unitOfWork.MultiProjectRepository.GetByFilter(p => p.NE_Nr == "203792153");

            timer1.Stop();
            Console.WriteLine(timer1.Elapsed.TotalMilliseconds);

           return Ok(_mapper.Map<IEnumerable<MultiProjectDTO>>(result));

           // return Ok(result);
        }

        [HttpGet]
        [Route("GetSomeDataV3")]
        public IActionResult GetSomeDataFromDBV3()
        {
            var result = _unitOfWork.DeltatelPORepository.GetByFilter(p => p.PR_NO == "3611248906");

            return Ok(_mapper.Map<IEnumerable<Deltatel_PODTO>>(result));
        }

        [HttpGet]
        [Route("GetRelatedCoordinate")]
        public IActionResult GetRelatedCoordinate()
        {
            List<(float, float)> coordinates = new List<(float, float)>();

            var query = _unitOfWork.ZuganssdatenAktuellRepository.GetByFilter(p => p.COOP_Tausch == "T: Verkauft-C")
                .Select(x => new { x.Ostl_Lange_WGS84, x.Nordl_Breite_WGS84 });

            foreach (var item in query)
            {
                var item1 = item.Ostl_Lange_WGS84;

                var item2 = item.Nordl_Breite_WGS84;

                if (item1 == null || item2 == null)
                {
                    continue;
                }

                var result = ConvertCoordinate.ConvertOperation(item2, item1);

                coordinates.Add((result.Latitude, result.Longitude));
            }
            string json = JsonConvert.SerializeObject(coordinates.Take(50), Formatting.Indented);

            return Ok(json);
        }









        //[HttpPost]
        //[Route("Authenticate")]
        //public IActionResult AuthenticateUser(UserInput userInput)
        //{
        //    var result = _EntityDbContext.UserInputs  //now only one user check
        //        .Any(
        //        p => p.UserName == userInput.UserName &&
        //        p.Password == userInput.Password
        //        );

        //    ArgumentNullException.ThrowIfNull(result);


        //    if (result)
        //    {
        //        return Ok();
        //    }
        //    else
        //    {
        //        return Unauthorized();
        //    }

        //}
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


    //[HttpGet]
    //[Route("RelatedQuery")]
    //public async Task<IActionResult> RelatedQuery(CancellationToken cancellationToken)
    //{
    //    var timer = new Stopwatch();

    //    timer.Start();

    //    var result = _e .RouterAktuell
    //        .Include(t1 => t1.Projekt_ID)
    //        .Include(t2 => t2.SAT)
    //        .ToList()
    //        .Select(res => new RouterAktuellDTO
    //        {
    //            Projekt_ID = res.Projekt_ID
    //        });

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
