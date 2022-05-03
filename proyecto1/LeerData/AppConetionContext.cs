
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    public class AppConetionContext : DbContext
    {
        private const string connectionString = @"Data Source=DESKTOP-N97UL5I; Initial Catalog=BDDEJEMPLO; Persist Security Info=True; User ID=sa; Password=D3LL";
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        //Modelo de datos modificado
        public DbSet<Usuario> Usuario{get;set;}
    }
}