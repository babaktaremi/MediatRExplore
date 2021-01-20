using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatRExploration.Data.Model;

namespace MediatRExploration.Data.Repositories.BookRepository
{
    public class BookMockRepository:IBookRepository
    {
        private List<Book> _books=new List<Book>
        {
            new Book{Title = "Moby Dick",Author ="Herman Melville",Id = "1",PublishYear = 1851},
            new Book{Title = "Harry Potter and the Sorcerer's Stone",Author ="J. K. Rowling",Id = "2",PublishYear = 1997},
            new Book{Title = "The Lord of the Rings",Author ="J. R. R. Tolkiene",Id = "3",PublishYear = 1954},
            new Book{Title = "Treasure Island",Author =" Robert Louis Stevenson",Id = "4",PublishYear = 1883},
            new Book{Title = "Gulliver's travels",Author ="Jonathan Swift",Id = "5",PublishYear = 1726},
        };

        public List<Book> GetAllBooks()
        {
            return _books;
        }

        public Book GetBookById(string id)
        {
            return _books.FirstOrDefault(b => b.Id.Equals(id));
        }

        public bool AddBook(Book book)
        {
           _books.Add(book);
           return true;
        }
    }
}
