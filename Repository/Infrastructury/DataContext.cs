using System.Data.Entity;
using Domain.Entity;

namespace infrastructury
{
    public class DataContext : DbContext
    {
        public DbSet<Users> User { get; set; }
        public DataContext()
           : base("name=Context")
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DataContext>(new CreateDatabaseIfNotExists<DataContext>());
        }

    }
}
