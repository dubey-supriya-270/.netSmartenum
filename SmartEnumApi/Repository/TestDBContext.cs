using static SmartEnumApi.Repository.TestDBContext;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace SmartEnumApi.Repository
{
    public class TestDBContext : DbContext
    {
        public TestDBContext(DbContextOptions<TestDBContext> options) : base(options)
        {
        }
        public DbSet<Order> orders { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
           
                modelBuilder.Entity<Order>().Property(e => e.status)
                    .HasConversion(
                        v => v.Value,
                        v => StatusEnum.FromValue(v));
            base.OnModelCreating(modelBuilder);


        }
        
    }
}
