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
            CreateMap<AddRegionDTO, Region>();
            CreateMap<UpdateWalkDTO, Walk>();
            CreateMap<Walk, WalkEntity>().ReverseMap();

            //Property expliciet mappen
            CreateMap<RegionEntity, Region>()
                .ForMember(x => x.Beschrijving, y => y.MapFrom(z => z.Description))
                .ReverseMap();
        }
    }
}
