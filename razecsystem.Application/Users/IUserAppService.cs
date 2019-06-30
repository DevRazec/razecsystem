using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using razecsystem.Roles.Dto;
using razecsystem.Users.Dto;

namespace razecsystem.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}