using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryCatalog.CORE;
using LibraryCatalog.CORE.Models;
using LibraryCatalog.SERVICES;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryCatalog.API.Controllers
{
    [Route("api/[controller]")]
    public class AuthorsController : Controller
    {

        private readonly IAuthorService _authorService;

        AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        // GET: api/values
        [HttpGet]
        public ActionResult Get()
        {
            var authorServiceResult = _authorService.GetAll();
            if (authorServiceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(authorServiceResult.Error);
            return Ok(authorServiceResult.Result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] AuthorDataTransferObjet author)
        {
            var authorServiceResult = _authorService.Add(author);
            if (authorServiceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(authorServiceResult.Error);
            return Ok(authorServiceResult.Result);
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
