using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myDemoApp.API.Data;
using Microsoft.EntityFrameworkCore; // added for async request(i.e ToListAsync)
using Microsoft.AspNetCore.Authorization;

namespace myDemoApp.API.Controllers
{
    //[Authorized]   
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public DataContext _context;

        //creating requests to get data from DB
        public ValuesController(DataContext context) //injecting dataContext and its object
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            //return new string[] { "value1", "value2" };
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }
       // [AllowAnonymous]
        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            //return "value";
            var value =await _context.Values.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
