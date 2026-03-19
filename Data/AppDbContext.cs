using Microsoft.EntityFrameworkCore;
using TarefasApi.Models;
using TarefasApi.Data;

namespace TarefasApi.Data;

public class AppDbContext : DbContext
{
    public DbSet<Tarefa> Tarefas { get; set; } = null!;

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}