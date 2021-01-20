using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatRExploration.Application.BookApplication.GetBookById;

namespace MediatRExploration.Controllers
{
    [ApiController]
    [Route("Api/Books")]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetBook")]
        public async Task<IActionResult> GetBookById(string id)
        {
            var book = await _mediator.Send(new GetBookByIdRequest {BookId = id}); //instance of a book

            if (book == null)
                return NotFound();

            return Ok(book);
        }
    }
}
