using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Assignment.DbData;
using MVC_Assignment.Models;

namespace MVC_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReactController : ControllerBase
    {
        readonly ApplicationDbContext _context;


        public ReactController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Person> GetData()
        {
            var data = _context.People;

            return data;
        }
    }
}
