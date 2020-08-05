using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller_Testi : ControllerBase
    {
        // GET: api/<controller_testi>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller_testi>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller_testi>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller_testi>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller_testi>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
