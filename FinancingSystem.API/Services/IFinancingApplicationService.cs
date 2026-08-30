using FinancingSystem.API.DTOs;

namespace FinancingSystem.API.Services
{
    public interface IFinancingApplicationService
    {
        Task<ApplicationResponseDto> CreateAsync(int userId, CreateApplicationDto dto);
        Task<IEnumerable<ApplicationResponseDto>> GetMyApplicationsAsync(int userId);
        Task<IEnumerable<ApplicationResponseDto>> GetAllApplicationsAsync();
        Task<ApplicationResponseDto?> GetByIdAsync(int id);
        Task<ApplicationResponseDto> ReviewApplicationAsync(int id, ReviewApplicationDto dto);
    }
}