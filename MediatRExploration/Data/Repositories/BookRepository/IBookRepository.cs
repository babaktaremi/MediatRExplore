using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatRExploration.Data.Model;

namespace MediatRExploration.Data.Repositories.BookRepository
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        Book GetBookById(string id);
        bool AddBook(Book book);

    }
}
