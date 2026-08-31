namespace FinancingSystem.API.DTOs
{
    public class CreateApplicationDto
    {
        public decimal Amount { get; set; }
        public int TenureMonths { get; set; }
    }
}