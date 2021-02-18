using System;
using System.Linq;

//repo patterned after the book model attributes
namespace assignment5.Models
{
    public interface IBookRepository
    {
        IQueryable<BookModel> Books { get; }
    }
}
