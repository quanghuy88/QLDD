using Abp.Authorization;
using RIS.Authorization.Roles;
using RIS.Authorization.Users;

namespace RIS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
