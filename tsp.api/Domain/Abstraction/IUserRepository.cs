using tsp.api.Domain.Core.Base;
using tsp.api.Domain.DTOs;

namespace tsp.api.Domain.Abstraction
{
    public interface IUserRepository
    {
        Task<BaseResponseModel> Register(RegisterRequestDTO request);
        Task<BaseResponseModel> Login(LoginRequestDTO request);
    }
}
