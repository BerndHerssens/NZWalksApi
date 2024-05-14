using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalksApi.Data.Entities
{
    public class WalkEntity : IEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        [Required]
        [Range(1, 20)]
        public double LengthInKm { get; set; }

        //Navigation properties
        public int RegionID { get; set; }

        public RegionEntity Region { get; set; }
    }
}
