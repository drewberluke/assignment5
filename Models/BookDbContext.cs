using System;
using Microsoft.EntityFrameworkCore;

//create db context 
namespace assignment5.Models
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base (options)
        {

        }
        public DbSet<BookModel> Books { get; set; }
    }
}
