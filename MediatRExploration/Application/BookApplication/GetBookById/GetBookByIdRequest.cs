using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatRExploration.Data.Model;

namespace MediatRExploration.Application.BookApplication.GetBookById
{
    public class GetBookByIdRequest:IRequest<Book>
    {
        public string BookId { get; set; }
    }
}
