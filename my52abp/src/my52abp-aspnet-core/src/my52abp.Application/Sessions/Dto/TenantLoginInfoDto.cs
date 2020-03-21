using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using my52abp.MultiTenancy;

namespace my52abp.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
