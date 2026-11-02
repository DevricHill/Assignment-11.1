using Assignment_11._1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_11._1.Data
{
    public class BookInventoryContext : DbContext
    {
        public DbSet<BookInventory> BookInventories { get; set; }

        public BookInventoryContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=CCAD23BookInventorys;Trusted_Connection=True;Integrated Security=True;trustservercertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookInventory>().HasData(
                new BookInventory() 
                {   
                    ISBN = 1,
                    AuthorName = "Author",
                    Description = "Test Description",
                    Name ="The First Real Book"
                }
            );
        }

    }
}
