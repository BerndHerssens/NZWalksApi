using NZWalksApi.Business.Enums;

namespace NZWalksApi.Business.Models
{
    public class Region
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Beschrijving { get; set; }
        public BeautyGrade BeautyGrade { get; set; }
        public List<Walk> WalksInRegion { get; set; } = new List<Walk>();
    }
}