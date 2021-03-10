using BookHouse.DataAccess.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHouse.DataAccess.Concrete
{
    public class BookHouseContext :DbContext
    {
        public BookHouseContext()
        {
            Database.Connection.ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=BookHouseDb;Trusted_Connection=True;";
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books  { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher>  Publishers { get; set; }
        public DbSet<Store>  Stores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasOptional(c => c.Parent).WithMany(c => c.Children);

            modelBuilder.Entity<Book>().HasMany<Store>(b => b.Stores).WithMany(s => s.Books).Map(map =>
              {
                  map.MapLeftKey("BookId");
                  map.MapRightKey("StoreId");
                  map.ToTable("BookStores");
              });

            modelBuilder.Entity<Book>()
                .HasRequired<Author>(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey<int>(b => b.AuthorId);

            modelBuilder.Entity<Book>()
                .HasRequired<Publisher>(b => b.Publisher)
                .WithMany(p => p.Books)
                .HasForeignKey<int>(b => b.PublisherId);

            modelBuilder.Entity<Author>()
                .HasMany<Publisher>(a => a.Publishers)
                .WithMany(p => p.Authors)
                .Map(map =>
                {
                    map.MapLeftKey("AuthorId");
                    map.MapRightKey("PublisherId");
                    map.ToTable("AuthorPublishers");
                });

            modelBuilder.Entity<Book>().Property(b => b.BookName).IsRequired();
            modelBuilder.Entity<Book>().Property(b => b.Summary).HasMaxLength(500);
        }
    }
}
