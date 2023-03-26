using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL
{
    public class BAContex : DbContext
    {
        public BAContex()
        {

        }
        public BAContex(DbContextOptions<BAContex> contextOptions) : base(contextOptions)
        {

        }
        public DbSet<Autor> Autors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=BooksDb;Trusted_Connection=True;TrustServerCertificate=True");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(ent =>
            {
                ent.HasKey(x => x.BookID);
                ent.Property(x => x.Name).IsRequired();
            });
            modelBuilder.Entity<Autor>(ent =>
            {
                ent.HasKey(a => a.AutorID);
                ent.Property(a => a.Name).IsRequired();
            });


                base.OnModelCreating(modelBuilder);

        }

    }
}