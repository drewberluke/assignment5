using System;
using System.Linq;

//database query saves to variable context, uses repo as the pattern 
namespace assignment5.Models
{
    public class EFBookRepository:IBookRepository
    {
        private BookDbContext _context;

        public EFBookRepository(BookDbContext context)
        {
            _context = context;
        }

        public IQueryable<BookModel> Books => _context.Books;
    }
}
