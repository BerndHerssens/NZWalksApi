namespace NZWalksApi.DTO
{
    public class UpdateWalkDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public int RegionID { get; set; }
    }
}
