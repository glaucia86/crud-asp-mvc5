using System.Data.Entity.Migrations;
using GL.ManagementApp.Infra.Data.Context;

namespace GL.ManagementApp.Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ManagementAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ManagementAppContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
