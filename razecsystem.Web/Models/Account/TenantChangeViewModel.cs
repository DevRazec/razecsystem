using Abp.AutoMapper;
using razecsystem.Sessions.Dto;

namespace razecsystem.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}