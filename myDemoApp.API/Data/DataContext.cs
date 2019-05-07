using Microsoft.EntityFrameworkCore;
using myDemoApp.API.Models;

namespace myDemoApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}
               public DbSet<Value> Values { get; set; }
    
    }
}