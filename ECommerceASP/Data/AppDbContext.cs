
using Microsoft.EntityFrameworkCore;
using ECommerceASP.Models;

namespace ECommerceASP.Data
{

    public class AppDbContext : DbContext  //Inheriting from 'DbContext : is responsible to interact with database '
    {

        //Constructor that takes DbContextOptions<AppDbContext>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<NUser> Users { get; set; }
             //Model(class) //Table

        public DbSet<Categories> Categories { get; set; }
    }
}
