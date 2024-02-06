using Microsoft.EntityFrameworkCore;

namespace MyToDo.Api.Model {
    public class MyToDoDbContext : DbContext{
        public MyToDoDbContext(DbContextOptions<MyToDoDbContext> options) : base(options) {

        }

        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Memo> Memos { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
