using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using FinancingSystem.API.Data;
using FinancingSystem.API.DTOs;
using FinancingSystem.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace FinancingSystem.API.Services
{
    public class AuthService : IAuthService
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthService(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<AuthResponseDto> RegisterAsync(RegisterDto dto)
        {
            await Task.CompletedTask;
            return new AuthResponseDto();
        }

        public async Task<AuthResponseDto> LoginAsync(LoginDto dto)
        {
            await Task.CompletedTask;
            return new AuthResponseDto();
        }
    }
}