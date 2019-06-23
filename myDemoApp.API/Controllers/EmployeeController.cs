using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myDemoApp.API.Data;
using Microsoft.EntityFrameworkCore; // added for async request(i.e ToListAsync)
using Microsoft.AspNetCore.Authorization;

namespace myDemoApp.API.Controllers
{   [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController: ControllerBase
    {
         public DataContext _context;
         
    public EmployeeController(DataContext context) //injecting dataContext and its object
    {
         _context = context;
    }
     // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetEmployeeDatas()
        { 
            //return new string[] { "value1", "value2" };
            var getempData = await _context.EmployeeDatas.ToListAsync();
            return Ok(getempData);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeData(int id)
        {
            //return "value";
            var value =await _context.EmployeeDatas.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }
    }

}