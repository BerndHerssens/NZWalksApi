using System.ComponentModel.DataAnnotations;

namespace NZWalksApi.DTO
{
    public class AddRegionDTO
    {
        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Beschrijving { get; set; }

        [Required]
        public int BeautyGrade { get; set; }
    }
}