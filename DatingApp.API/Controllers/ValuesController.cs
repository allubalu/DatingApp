using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        readonly DatingAppContext _context = null;
        public ValuesController()
        {
            var optionsBuilder = new DbContextOptionsBuilder<DatingAppContext>();
            optionsBuilder.UseSqlServer("Server=(LocalDb)\\v11.0;Database=DatingApp;Trusted_Connection=True;MultipleActiveResultSets=true");
            //Microsoft.Extensions.Configuration.ConfigurationSection("DatingAppDB"));

            _context = new DatingAppContext(optionsBuilder.Options);
             //new DatingAppContext();
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return  Ok(await _context.values.ToListAsync());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _context.values.FirstOrDefaultAsync(Value=> Value.ID == id));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
