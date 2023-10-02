using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        private readonly string Host = "localhost";
        private readonly string Port = "32769";
        private readonly string Name = "shop-db";
        private readonly string Password = "password";
        private readonly string Username = "postgres";

        //public StoreContext()
        //{
        //    //Database.EnsureCreated();
        //}

        //public StoreContext(DbContextOptions<StoreContext> options)
        //    : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString =
                $"Host={Host};Port={Port};Database={Name};Username={Username};Password={Password}";

            optionsBuilder.UseNpgsql(connectionString);

            //
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
