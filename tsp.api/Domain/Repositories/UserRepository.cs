using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using tsp.api.Domain.Abstraction;
using tsp.api.Domain.Core.Base;
using tsp.api.Domain.Core.Entities.Users;
using tsp.api.Domain.Database.Context;
using tsp.api.Domain.DTOs;

namespace tsp.api.Domain.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<Role> roleManager;
        private readonly CommerceContext context;
        private BaseResponseModel responseModel;
        public UserRepository(UserManager<User> userManager, 
                              BaseResponseModel responseModel, 
                              RoleManager<Role> roleManager, 
                              CommerceContext context)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.context = context;
            this.responseModel = responseModel;
        }
        public async Task<BaseResponseModel> Login(LoginRequestDTO request)
        {
            User user = await context.Users.FirstOrDefaultAsync(x => x.Email.ToLower() == request.Email.ToLower());
            if(user is not null)
            {
                bool isValid = await userManager.CheckPasswordAsync(user,request.Password);
                if(!isValid)
                {
                    responseModel.isSuccess = false;
                    responseModel.Message = "İşlem Başarısız.";
                    return responseModel;
                }
                else
                {
                    responseModel.isSuccess = true;
                    responseModel.Message = "İşlem Başarılı.";
                    return responseModel;
                }
            }
            else
            {
                responseModel.isSuccess = false;
                responseModel.Message = "Kullanıcı Bulunamadı.";
                return responseModel;
            }
        }

        public Task<BaseResponseModel> Register(RegisterRequestDTO request)
        {
            throw new NotImplementedException();
        }
    }
}
