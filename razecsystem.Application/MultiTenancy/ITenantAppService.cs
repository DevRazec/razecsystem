using Abp.Application.Services;
using Abp.Application.Services.Dto;
using razecsystem.MultiTenancy.Dto;

namespace razecsystem.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
