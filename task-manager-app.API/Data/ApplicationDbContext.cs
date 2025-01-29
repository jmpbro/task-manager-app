using Microsoft.EntityFrameworkCore;
using task_manager_app.Models;
using Task = task_manager_app.Models.Task;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Task> Tasks { get; set; }
    public DbSet<User> Users { get; set; }
}
