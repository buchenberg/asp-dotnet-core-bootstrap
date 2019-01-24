using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WidgetsController : ControllerBase
    {
        // GET api/widgets
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "widgeta", "widget2" };
        }

        // GET api/widgets/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "widget";
        }

        // POST api/widgets
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/widgets/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/widgets/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
