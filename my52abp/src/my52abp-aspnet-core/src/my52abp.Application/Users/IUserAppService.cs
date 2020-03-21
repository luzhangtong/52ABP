using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using my52abp.Roles.Dto;
using my52abp.Users.Dto;

namespace my52abp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
