using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatRExploration.Data.Model;
using MediatRExploration.Data.Repositories.BookRepository;

namespace MediatRExploration.Application.BookApplication.GetBookById
{
    public class GetBookByIdRequestHandler:IRequestHandler<GetBookByIdRequest,Book>
    {
        private readonly IBookRepository _bookRepository;

        public GetBookByIdRequestHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Task<Book> Handle(GetBookByIdRequest request, CancellationToken cancellationToken)
        {

            return Task.FromResult(_bookRepository.GetBookById(request.BookId));
        }
    }
}
