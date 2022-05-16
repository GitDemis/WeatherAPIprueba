using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        IUserDataService UserDataService;
        public UserController(IUserDataService userData)
        {
            UserDataService = userData;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get([FromServices] IUserDataService dataService)
        {
            return UserDataService.GetValues().Union(dataService.GetValues()).ToList();
        }

        [HttpGet("{id}")]

        public ActionResult<string> get(int id)
        {
            return "value";
        }

        [HttpPost]

        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]

        public void Put(int id, [FromBody] string value)
        {

        }

        [HttpDelete]

        public void Delete(int id)
        { }
    }
}
