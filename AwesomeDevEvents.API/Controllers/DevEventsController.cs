using AwesomeDevEvents.API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeDevEvents.API.Controllers
{
    [Route("api/events")]
    [ApiController]
    public class DevEventsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll() 
        {

        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {

        }

        [HttpPost]
        public IActionResult Post(DevEvent devEvent)
        {

        }

        [HttpPut("{id}")]
        public IActionResult Update(DevEvent devEvent)
        {

        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {

        }
    }
}
