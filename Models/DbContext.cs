using Inventario.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Empleado> Productos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Marca> Marcas { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Empleado> Empleados { get; set; }

public DbSet<Inventario.Models.Productos> Productos_1 { get; set; } = default!;
}
