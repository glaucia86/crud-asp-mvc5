using GL.ManagementApp.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

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

        /// <summary>
        /// Método responsável por criar modelos das classes do banco
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Aqui ele vai remover a pluralização das tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //Aqui ele evitará de remover a tables de maneira cascada
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Aqui estou indicando qual propriedade é a Chave Primária
            //Que nesse caso são as propriedades com terminação "Id":
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            //Aqui estou configurando que, todas as propriedades do tipo 'string' sejam do tipo
            //'varchar'
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            //Aqui estou configurando que, todas as propriedades do tipo 'string
            //tenham tamanho máximo de 100
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            base.OnModelCreating(modelBuilder);
        }
    }
}
