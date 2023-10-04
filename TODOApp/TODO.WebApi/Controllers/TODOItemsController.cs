using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TODO.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TODOItemsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<String> Get() 
        {
            return new string[] { "value 1", "value 2" };
        }
  // Get api/<TODOItemsController>5
        [HttpGet("{id}")]
        public String Get(int id) 
        {
            return "value";
        }
        // POST api/<TODOItemsController>
        [HttpPost]
        public void Post([FromBody] String value) 
        {
        }
        // PUT api/<TODOItemsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) 
        {
        }
        // DELETE api/<TODOItemsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) 
        {
        }

    }
}
