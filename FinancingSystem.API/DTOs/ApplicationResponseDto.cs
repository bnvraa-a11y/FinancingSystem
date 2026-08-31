namespace FinancingSystem.API.DTOs
{
    public class ApplicationResponseDto
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int TenureMonths { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
        public string ApplicantName { get; set; } = string.Empty;
    }
}