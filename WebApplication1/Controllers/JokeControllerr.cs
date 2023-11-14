using Microsoft.AspNetCore.Mvc;
using WebApplication1.JokeModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/jokes")]
    [ApiController]
    public class JokeControllerr : ControllerBase
    {
        // GET: api/<JokeControllerr>
        [HttpGet]
        public IActionResult Get()
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            return Ok(context.Jokes.ToList());
        }

        // GET api/<JokeControllerr>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<JokeControllerr>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<JokeControllerr>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<JokeControllerr>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
