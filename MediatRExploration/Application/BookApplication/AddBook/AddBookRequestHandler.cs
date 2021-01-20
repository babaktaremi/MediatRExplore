using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatRExploration.Data.Model;
using MediatRExploration.Data.Repositories.BookRepository;

namespace MediatRExploration.Application.BookApplication.AddBook
{
    public class AddBookRequestHandler:IRequestHandler<AddBookRequest,bool>
    {
        private readonly IBookRepository _bookRepository;

        public AddBookRequestHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Task<bool> Handle(AddBookRequest request, CancellationToken cancellationToken)
        {
            _bookRepository.AddBook(new Book
                {Author = request.Author, Id = request.Id, PublishYear = request.PublishYear, Title = request.Title});

            return Task.FromResult(true);
        }
    }
}
