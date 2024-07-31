using Microsoft.EntityFrameworkCore;
using PersoAnimes.Models;

namespace PersoAnimes.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }

        public DbSet<PersoModel> Personagens { get; set; } // Nome da Tabela Personagens


    }
}
