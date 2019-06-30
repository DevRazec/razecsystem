using System.Collections.Generic;
using razecsystem.Roles.Dto;
using razecsystem.Users.Dto;

namespace razecsystem.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}