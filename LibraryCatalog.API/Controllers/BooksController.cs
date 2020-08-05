using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryCatalog.SERVICES;
using LibraryCatalog.CORE.Models;
using LibraryCatalog.CORE;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryCatalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;

        BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET: api/values
        [HttpGet]
        public ActionResult Get()
        {
            var bookServiceResult = _bookService.GetAll();
            if (bookServiceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(bookServiceResult.Error);
            return Ok(bookServiceResult.Result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] BookDataTransferObjet book)
        {
            var bookServiceResult = _bookService.Add(book);
            if (bookServiceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(bookServiceResult.Error);
            return Ok(bookServiceResult.Result);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
