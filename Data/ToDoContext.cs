using Microsoft.EntityFrameworkCore;

public class ToDoContext : DbContext{
    public ToDoContext(DbContextOptions<ToDoContext> options ) : base(options) {}
    
    public DbSet<Task> Tasks {get; set;}

}