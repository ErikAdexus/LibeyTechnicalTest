using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;

namespace LibeyTechnicalTestAPI.Controllers.LibeyUser
{
    [ApiController]
    [Route("[controller]")]
    public class LibeyUserController : Controller
    {
        private readonly ILibeyUserAggregate _aggregate;
        public LibeyUserController(ILibeyUserAggregate aggregate)
        {
            _aggregate = aggregate;
        }
        [HttpGet]
        public IActionResult AllLibeyUser()
        {
            var row = _aggregate.AllLibeyUser();
            return Ok(row);
        }
        [HttpGet]
        [Route("{documentNumber}")]
        public IActionResult FindResponse(string documentNumber)
        {
            var row = _aggregate.FindResponse(documentNumber);
            return Ok(row);
        }
        [HttpPost]       
        public IActionResult Create(LibeyTechnicalTestDomain.LibeyUserAggregate.Domain.LibeyUser libeyUser)
        {
             _aggregate.Create(libeyUser);
            return Ok(true);
        }
        [HttpPut]
        public IActionResult UpdateLibeyUser(string documentNumber, UserUpdateorCreateCommand command)
        {
            _aggregate.UpdateLibeyUser(documentNumber, command);
            return Ok(true);
        }
        [HttpDelete]
        [Route("{documentNumber}")]
        public IActionResult DeleteLibeyUser(string documentNumber)
        {
            _aggregate.DeleteLibeyUser(documentNumber);
            return Ok(true);
        }
    }
}