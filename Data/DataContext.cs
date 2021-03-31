using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProAgil.api.Data;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.Data.Sqlite;
using ProAgil.api.Models;

namespace ProAgil.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlite("Data Source=ProAgil.db");
        // }

        public DbSet<Evento> Eventos { get; set; }
    }
}