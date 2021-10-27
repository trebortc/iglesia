using IglesiaModel.Model;
using Microsoft.EntityFrameworkCore;

namespace Iglesia.Model
{
    public class IglesiaDb: DbContext
    {
        public DbSet<Parroquia> Parroquia { get; set; }
        public DbSet<Parroco> Parroco { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "server=localhost;port=3306;database=iglesia;user=root;";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
