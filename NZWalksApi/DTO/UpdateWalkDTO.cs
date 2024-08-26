using System.ComponentModel.DataAnnotations;

namespace NZWalksApi.DTO
{
    public class UpdateWalkDTO
    {
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Dit veld is vereist.")]
        [Range(2, 20, ErrorMessage = "Onze wandelingen zijn tussen 2 en 20km.")]
        public double LengthInKm { get; set; }

        public int RegionID { get; set; }
    }
}