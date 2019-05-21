using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myDemoApp.API.Data;
using Microsoft.EntityFrameworkCore; // added for async request(i.e ToListAsync)
namespace myDemoApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController: ControllerBase
    {
         public DataContext _context;
         
    public PostsController(DataContext context) //injecting dataContext and its object
    {
         _context = context;
    }
     // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetPostDatas()
        { 
            //return new string[] { "value1", "value2" };
            var getpostData = await _context.PostDatas.ToListAsync();
            return Ok(getpostData);
        }

        // GET api/values/5
    /*   [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeData(int id)
        {
            //return "value";
            var value =await _context.PostDatas.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }
         */ 
    }

}