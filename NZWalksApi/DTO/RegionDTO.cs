using NZWalksApi.Business.Models;
using NZWalksApi.Data;

namespace NZWalksApi.DTO
{
    public class RegionDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Beschrijving { get; set; }
        public string BeautyGrade { get; set; }
        public List<WalkSmallDTO> ListWalksInRegion { get; set; } = new List<WalkSmallDTO>();
    }
}
