using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RoleBasedAuthProject.Models
{
    public class RBADbContext : DbContext
    {
        public RBADbContext(): base ("RBADbContext")
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRoleMapping> UserRoleMappings { get; set; }
    }
}