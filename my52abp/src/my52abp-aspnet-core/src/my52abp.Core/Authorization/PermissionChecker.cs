using Abp.Authorization;
using my52abp.Authorization.Roles;
using my52abp.Authorization.Users;

namespace my52abp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
