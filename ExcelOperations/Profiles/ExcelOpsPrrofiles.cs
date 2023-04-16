using AutoMapper;
using ExcelOperations.DocEntity.Entity.POC;
using ExcelOperations.Entities.DocEntityDTO;

namespace ExcelOperations.Profiles
{
    public class ExcelOpsPrrofiles : Profile
    {
        public ExcelOpsPrrofiles()
        {
            //Soruce -> target
            CreateMap<MultiProject, MultiProjectDTO>();
        }
    }
}
