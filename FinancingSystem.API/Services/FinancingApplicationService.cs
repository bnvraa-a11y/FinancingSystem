using FinancingSystem.API.DTOs;

namespace FinancingSystem.API.Services
{
    public class FinancingApplicationService : IFinancingApplicationService
    {
        // ...
        public Task<ApplicationResponseDto> CreateAsync(int userId, CreateApplicationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ApplicationResponseDto>> GetAllApplicationsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationResponseDto?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ApplicationResponseDto>> GetMyApplicationsAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationResponseDto> ReviewApplicationAsync(int id, ReviewApplicationDto dto)
        {
            throw new NotImplementedException();
        }
    }
}