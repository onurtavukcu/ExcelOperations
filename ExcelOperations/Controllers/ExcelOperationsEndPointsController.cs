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

            return Ok(_mapper.Map<IEnumerable<MultiProjectDTO>>(result));
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
    }
}
