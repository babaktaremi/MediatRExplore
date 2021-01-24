using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatRExploration.Application.Common;

namespace MediatRExploration.Application.BookApplication.AddBook
{
    public class AddBookRequest:IRequest<bool>,ICommitable
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublishYear { get; set; }
    }
}
