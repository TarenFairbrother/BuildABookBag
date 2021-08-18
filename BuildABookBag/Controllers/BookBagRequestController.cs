using BuildABookBag.Models;
using BuildABookBag.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildABookBag.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookBagRequestController : ControllerBase
    {
        private readonly IBookBagRepostitory _bookBagRepo;

        public BookBagRequestController(IBookBagRepostitory bookBagRepo)
        {
            _bookBagRepo = bookBagRepo;
        }

        [HttpPost]
        public async Task<IActionResult> AddBookBagRequest([FromBody] BookBagRequest bookBagRequest)
        {
            if (bookBagRequest == null)
                return BadRequest();

            await _bookBagRepo.AddNewBookBagRequest(bookBagRequest);

            return Ok("book bag request submitted");
        }

    }
}
