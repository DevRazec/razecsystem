using Abp.Authorization;
using razecsystem.Authorization.Roles;
using razecsystem.Authorization.Users;

namespace razecsystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
