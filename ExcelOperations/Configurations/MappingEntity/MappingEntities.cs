﻿using AutoMapper;
using ExcelOperations.DocEntity.Entity.POC;
using ExcelOperations.Entities.DocEntityDTO.POCDTO;

namespace ExcelOperations.Configurations.MappingEntity
{
    public class MappingEntities : Profile
    {
        public MappingEntities()
        {
            CreateMap<MultiProjectDTO, MultiProject>();                
        }
    }
}
