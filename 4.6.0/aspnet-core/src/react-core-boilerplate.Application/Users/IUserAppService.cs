using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using react-core-boilerplate.Roles.Dto;
using react-core-boilerplate.Users.Dto;

namespace react-core-boilerplate.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
