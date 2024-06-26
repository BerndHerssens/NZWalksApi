﻿namespace NZWalksApi.Business.Models
{
    public class Walk
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public double LengthInMeters { get { return LengthInKm * 1000; } }
        public double LengthInMiles { get { return LengthInKm / 1.6; } }
        public Region Region { get; set; }

        public int RegionID { get; set; }
    }
}
