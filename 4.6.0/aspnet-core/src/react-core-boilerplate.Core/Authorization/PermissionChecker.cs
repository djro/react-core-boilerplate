using Abp.Authorization;
using react-core-boilerplate.Authorization.Roles;
using react-core-boilerplate.Authorization.Users;

namespace react-core-boilerplate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
