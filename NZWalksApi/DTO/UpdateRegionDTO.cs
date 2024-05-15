using NZWalksApi.Data;

namespace NZWalksApi.DTO
{
    public class UpdateRegionDTO
    {
        public string Name { get; set; }
        public string Beschrijving { get; set; }
        public BeautyGrade BeautyGrade { get; set; }
    }
}
