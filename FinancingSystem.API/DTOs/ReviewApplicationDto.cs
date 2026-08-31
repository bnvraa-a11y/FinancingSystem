using System.ComponentModel.DataAnnotations;

namespace FinancingSystem.API.DTOs
{
    public class ReviewApplicationDto
    {
        [Required]
        public bool IsApproved { get; set; }

        public string Remarks { get; set; } = string.Empty;
    }
}