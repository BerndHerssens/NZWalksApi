using AutoMapper;
using NZWalksApi.Business.Models;
using NZWalksApi.Data.Entities;
using NZWalksApi.DTO;

namespace NZWalksApi.Configuration
{
    public class NZWalksProfile : Profile
    {
        public NZWalksProfile()
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
