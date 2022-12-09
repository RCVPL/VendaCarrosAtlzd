using Microsoft.EntityFrameworkCore;

namespace VendaCarros.Models;

public class VendaCarrosContext : DbContext
{
    public DbSet<Carro> Carro { get; set; }
    public DbSet<Comprador> Comprador get; set; }
    
    public VendaCarrosContext(DbContextOptions<VendaCarrosContext> options) : base(options)
    {
        
    }
}