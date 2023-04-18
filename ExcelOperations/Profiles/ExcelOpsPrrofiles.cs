using AutoMapper;
using ExcelOperations.DocEntity;
using ExcelOperations.DocEntity.Aktuell;
using ExcelOperations.DocEntity.Entity.Aktuell;
using ExcelOperations.DocEntity.Entity.Lager;
using ExcelOperations.DocEntity.Entity.PO;
using ExcelOperations.DocEntity.Entity.POC;
using ExcelOperations.DocEntity.Entity.Zugang;
using ExcelOperations.DocEntity.PO;
using ExcelOperations.Entities.DocEntityDTO.AktuellDTO;
using ExcelOperations.Entities.DocEntityDTO.LagerDTO;
using ExcelOperations.Entities.DocEntityDTO.POCDTO;
using ExcelOperations.Entities.DocEntityDTO.PODTO;
using ExcelOperations.Entities.DocEntityDTO.ZugangDTO;

namespace ExcelOperations.Profiles
{
    public class ExcelOpsPrrofiles : Profile
    {
        public ExcelOpsPrrofiles()
        {
            //Soruce -> target
            CreateMap<RouterAktuell, RouterAktuellDTO>();

            CreateMap<RouterAktuellOrderList, RouterAktuellOrderListDTO>();

            CreateMap<XWDMAktuell,XWDMAktuellDTO>();

            CreateMap<XWDMAktuellOrderList, XWDMAktuellOrderListDTO>();

            CreateMap<LagerCentral,LagerCentralDTO>();

            CreateMap<Cisco_PO, Cisco_PODTO>();

            CreateMap<Deltatel_PO, Deltatel_PODTO>();

            CreateMap<ZTE_PO, ZTE_PODTO>();

            CreateMap<JSLMultiProject, JSLMultiProjectDTO>();

            CreateMap<MultiProject, MultiProjectDTO>();

            CreateMap<RouterSwapAktuell,RouterSwapAktuellDTO>();

            CreateMap<ZugangsdatenAktuell, ZugangsdatenAktuellDTO>();
        }
    }
}
