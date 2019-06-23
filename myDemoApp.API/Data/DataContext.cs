using Microsoft.EntityFrameworkCore;
using myDemoApp.API.Models;

namespace myDemoApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}
               public DbSet<Value> Values { get; set; }
               public DbSet<EmployeeData> EmployeeDatas { get; set; }
               public DbSet<PostData> PostDatas { get; set; } //PostData -> model name ; PostDatas -> table name
               public DbSet<User> Users { get; set; }
    }
}