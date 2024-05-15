using System.ComponentModel.DataAnnotations;

namespace NZWalksApi.Data.Entities
{
    public class RegionEntity : IEntity
    {
        public DateTime Created { get ; set ; }

        public int ID { get ; set ; }

        public DateTime Updated { get; set; }

        public BeautyGrade BeautyGrade { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        //Navigation properties
        public List<WalkEntity> Walks { get; set; }
    }
}

namespace NZWalksApi.Data
{
    public enum BeautyGrade
    {
        Awful = 0,
        SlightlyDirty = 1,
        Normal = 2,
        Pretty = 3,
        MrPropreClean = 4,
    }
}