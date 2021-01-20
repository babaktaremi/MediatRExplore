using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatRExploration.Application.BookApplication.AddBook;
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

        [HttpPost("Create")]
        public async Task<IActionResult> CreateBook(AddBookRequest request)
        {
            var command = await _mediator.Send(request);

            if (command)
                return Ok();

            return BadRequest();
        }
    }
}
