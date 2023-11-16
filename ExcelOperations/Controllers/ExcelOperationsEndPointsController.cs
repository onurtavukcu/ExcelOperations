using Microsoft.AspNetCore.Mvc;
using ExcelOperations.Repository.UnitOfWork;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using ExcelOperations.Entities.DocEntityDTO.POCDTO;
using ExcelOperations.Entities.DocEntityDTO.PODTO;
using Newtonsoft.Json;
using ExcelOperations.Operations.MinorOperations.CoordinateOperation;
using System.Data;

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
        public ActionResult Get()
        {
            var routerAktuell = _unitOfWork.LagerCentralRepository.GetAll();

            return Ok(routerAktuell);

        }
       
        [HttpGet]
        [Route("GetSomeDataV2")]
        public IActionResult GetSomeDataFromDBV2(CancellationToken cancellationToken)
        {
            var result = _unitOfWork.MultiProjectRepository.GetByFilter(p => p.NE_Nr == "203792153");

            return Ok(_mapper.Map<IEnumerable<RouterSwapAktuellDTO>>(result));
        }

        [HttpGet]
        [Authorize(Roles = "1")]
        [Route("GetSomeDataAdmin")]
        public IActionResult GetDataAdmin(CancellationToken cancellationToken)
        {
            var result = _unitOfWork.MultiProjectRepository.GetByFilter(p => p.NE_Nr == "203792153");

            return Ok(_mapper.Map<IEnumerable<MultiProjectDTO>>(result));
        }

        [HttpGet]
        [Authorize(Roles = "2")]
        [Route("GetSomeDataRegular")]
        public IActionResult GetDataRegular(CancellationToken cancellationToken)
        {
            var result = _unitOfWork.MultiProjectRepository.GetByFilter(p => p.NE_Nr == "203792153");

            return Ok(_mapper.Map<IEnumerable<MultiProjectDTO>>(result));
        }

        [HttpGet]
        [Route("GetSomeDataV4Pageging")]
        public IActionResult GetAllData(int page = 1, int pageSize = 10)
        {
            var totalCount = _unitOfWork.DeltatelPORepository.GetAll().Count();

            var totalPages = (int)Math.Ceiling((decimal)totalCount / pageSize);

            var dataPerPages = _unitOfWork.DeltatelPORepository
                .GetAll()
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            return Ok(_mapper.Map<IEnumerable<Deltatel_PODTO>>(dataPerPages));
        }

        [HttpGet]
        [Route("GetAllProjectNumbers")]
        public IActionResult GetPRojectId()
        {
            var projectList = new List<int>();

            var lager = _unitOfWork.LagerCentralRepository.GetByFilter(t => t.PID != null).SelectMany(k=>k.PID);


            return Ok();
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

        //[HttpGet]
        //[Route("testConcreateTable")]
        //public IActionResult ConcreateRAble() 
        //{
        //    var result = from t1 in _unitOfWork.DbContext.MultiProjects
        //                 join t2 in _unitOfWork.DbContext.RouterAktuell on t1.Objekt_ID equals t2.Projekt_ID
        //                 join t3 in _unitOfWork.DbContext.Cisco_POs on t1.Objekt_ID equals t3.Objekt_ID
        //                 join t4 in _unitOfWork.DbContext.Deltatel_POs on t1.Objekt_ID equals t4.Site_Code
        //                 join t5 in _unitOfWork.DbContext.LagerCentrals on t1.Objekt_ID equals t5.PID
        //                 join t6 in _unitOfWork.DbContext.RouterAktuellOrderLists on t1.Objekt_ID equals t6.Projekt_ID
        //                 join t7 in _unitOfWork.DbContext.RouterSwapAktuells on t1.Objekt_ID equals t7.Projekt_ID
        //                 join t8 in _unitOfWork.DbContext.XWDMAktuelOrderLists on t1.Objekt_ID equals t8.Projekt_ID
        //                 join t9 in _unitOfWork.DbContext.XWDMAktuells on t1.Objekt_ID equals t9.Projekt_ID

        //                 select new
        //                 {
        //                     ProjectId =t1.Objekt_ID,
        //                     X = t1.Order, t1.Plan_Stx48,t1.Plan_Stx50,    // An exception has been raised that is likely due to a transient failure.
        //                     A = t1.Objekt_Herkunft,
        //                     B = t2.Projektstand,
        //                     C= t3.PO_Elemnt,
        //                     D= t4.Site_Code,
        //                     E= t5.PID,
        //                     F= t6.Projekt_ID,
        //                     G= t7.Projekt_ID,
        //                     H=t8.Projekt_ID,
        //                     I = t9.Projekt_ID
        //                 };


        //    return Ok(result);
        //}
    }
}
