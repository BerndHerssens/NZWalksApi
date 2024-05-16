using NZWalksApi.Data;
using System;
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
        [Range(0, 4)]
        public BeautyGrade BeautyGrade { get; set; }
    }
}
