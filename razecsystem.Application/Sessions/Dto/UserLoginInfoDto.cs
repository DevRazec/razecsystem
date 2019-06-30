using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using razecsystem.Authorization.Users;
using razecsystem.Users;

namespace razecsystem.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }
    }
}
