using System.ComponentModel.DataAnnotations;

namespace NZWalksApi.Data.Entities
{
    public class BeautyGradeEntity : IEntity
    {
        public int ID { get; set; }

        public DateTime Created { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public DateTime Updated { get; set; }
    }
}