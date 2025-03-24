using System.Collections.Generic;
using SprawdzianRS.src.Enums;

namespace SprawdzianRS.src.Models
{
    public class User
    {
        public User(string username)
        {
            Username = username;
            Roles = new List<Role>();
        }

        public string Username { get; set; }
        public List<Role> Roles { get; set; }

        public void AddRole(Role role)
        {
            if (!Roles.Contains(role)) Roles.Add(role);
        }
    }
}