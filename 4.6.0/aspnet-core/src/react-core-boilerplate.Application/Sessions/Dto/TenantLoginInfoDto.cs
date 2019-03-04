using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using react-core-boilerplate.MultiTenancy;

namespace react-core-boilerplate.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
