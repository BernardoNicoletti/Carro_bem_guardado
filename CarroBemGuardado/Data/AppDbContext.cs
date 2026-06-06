using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Veiculo> Veiculos { get; set; }

    public DbSet<TabelaPreco> TabelasPreco { get; set; }
}