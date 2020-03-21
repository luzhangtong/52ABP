using Abp.Application.Services;
using my52abp.MultiTenancy.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace my52abp.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<TenantDto> RegisterTenant(CreateTenantDto input);
    }
}
