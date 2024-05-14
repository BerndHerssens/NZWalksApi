using AutoMapper;
using NZWalksApi.Business.Models;
using NZWalksApi.Data.Entities;
using NZWalksApi.DTO;

namespace NZWalksApi.Configuration
{
    public class AutomapperAPIProfile : Profile
    {
        public AutomapperAPIProfile()
        {
            CreateMap<AddWalkDTO, Walk>();
            CreateMap<UpdateWalkDTO, Walk>();
            CreateMap<Walk, WalkEntity>().ReverseMap();
        }
    }
}
