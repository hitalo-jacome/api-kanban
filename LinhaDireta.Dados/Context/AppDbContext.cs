using LinhaDireta.Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace LinhaDireta.Dados.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Dominio.Entities.LinhaDireta> LinhaDireta { get; set; }
    public DbSet<StatusLinhaDireta> StatusLinhaDireta { get; set; }
    public DbSet<LinhaDiretaHistorico> LinhaDiretaHistorico { get; set; }
}
