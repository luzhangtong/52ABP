using Abp.Application.Services;
using Abp.Application.Services.Dto;
using my52abp.MultiTenancy.Dto;

namespace my52abp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

