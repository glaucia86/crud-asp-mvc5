using System.Data.Entity;

namespace GL.ManagementApp.Infra.Data.Context
{
    public class ManagementAppContext : DbContext
    {
        public ManagementAppContext()
            : base("App")
        {

        }
    }
}
