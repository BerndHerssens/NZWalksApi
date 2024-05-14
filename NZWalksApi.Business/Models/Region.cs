using NZWalksApi.Data;
using NZWalksApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
