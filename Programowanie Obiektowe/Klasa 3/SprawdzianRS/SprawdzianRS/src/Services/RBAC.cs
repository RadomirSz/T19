using System.Collections.Generic;
using SprawdzianRS.src.Enums;
using SprawdzianRS.src.Models;

namespace SprawdzianRS.src.Services
{
    public class RBAC
    {
        //Role-Based Access Control
        private readonly Dictionary<Role, List<Permission>> _rolePermissions;

        public RBAC()
        {
            _rolePermissions = new Dictionary<Role, List<Permission>>
            {
                {
                    Role.Administrator, new List<Permission>
                        { Permission.Read, Permission.Write, Permission.Delete, Permission.ManageUsers }
                },
                { Role.Manager, new List<Permission> { Permission.Read, Permission.Write } },
                { Role.User, new List<Permission> { Permission.Read } }
            };
        }

        public bool HasPermission(User user, Permission permission)
        {
            foreach (var role in user.Roles)
                if (_rolePermissions.ContainsKey(role) && _rolePermissions[role].Contains(permission))
                    return true;

            return false;
        }
    }
}