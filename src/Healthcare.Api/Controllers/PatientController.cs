using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Healthcare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        // GET: api/<PatientController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok("value");
        }

        // POST api/<PatientController>
        [HttpPost]
        /*
        public void Post([FromBody] string value)
        {
        }
        */
        public IActionResult Post(ProblemDetails problemDetails)
        {
            /*HttpContext.Response.Headers.Add("X-Paginated", "{ Item");*/
            return CreatedAtAction("api/Patient/2", problemDetails);
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
