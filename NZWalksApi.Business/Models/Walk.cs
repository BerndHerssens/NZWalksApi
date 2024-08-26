namespace NZWalksApi.Business.Models
{
    public class Walk
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double LengthInKm { get; set; }

        public double LengthInMeters => LengthInKm * 1000;

        public double LengthInMiles => LengthInKm / 1.6;

        public double WalkScore { get; set; }

        public int RegionID { get; set; }

        public Region Region { get; set; }
    }
}