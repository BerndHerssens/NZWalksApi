namespace NZWalksApi.DTO
{
    public class WalkDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public double LengthInMeters { get; set; }
        public double LengthInMiles { get; set; }
        public string RegioNaam { get; set; }
        public string RegioBeschrijving { get; set; }
    }
}
