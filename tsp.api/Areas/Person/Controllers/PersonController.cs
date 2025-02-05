using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tsp.api.Domain.Core.Entities.Users;

namespace tsp.api.Areas.Person.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public List<User> GetAll()
        {
            return new List<User>
            {
                new User { Name = "Aaaaaa", SurName = "Bbb", Email = "aaaaaa@aaaaaa.com" },
                new User { Name = "Bbbbbb", SurName = "Ccc", Email = "bbbbbb@bbbbbb.com" },
                new User { Name = "Cccccc", SurName = "Ddd", Email = "cccccc@cccccc.com" },
                new User { Name = "Dddddd", SurName = "Fff", Email = "dddddd@dddddd.com" },
                new User { Name = "Ffffff", SurName = "Eee", Email = "ffffff@ffffff.com" }
            };
        }
    }
}
