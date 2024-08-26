using System.ComponentModel.DataAnnotations;

namespace NZWalksApi.Data.Entities
{
    public class RegionEntity : IEntity
    {
        public int ID { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        public int I { get; set; }

        public int BeautyGrade { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        //Navigation properties
        public List<WalkEntity> Walks { get; set; }
    }
}