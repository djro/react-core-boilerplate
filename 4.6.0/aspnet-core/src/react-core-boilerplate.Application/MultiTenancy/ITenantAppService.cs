using Abp.Application.Services;
using Abp.Application.Services.Dto;
using react-core-boilerplate.MultiTenancy.Dto;

namespace react-core-boilerplate.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

