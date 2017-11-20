using GL.ManagementApp.Domain.Entities;
using System.Data.Entity;

namespace GL.ManagementApp.Infra.Data.Context
{
    public class ManagementAppContext : DbContext
    {
        public ManagementAppContext()
            : base("App")
        {
            //Default
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Address> Addresses { get; set; }
    }
}
