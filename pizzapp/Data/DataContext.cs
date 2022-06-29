using Microsoft.EntityFrameworkCore;
using pizzapp.Models;

namespace pizzapp.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    public DbSet<Pizza> Pizzas { get; set; }
}