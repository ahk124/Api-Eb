using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Post;
using Microsoft.AspNetCore.Mvc;
using Services.Repositories;

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        private readonly UserRepository _userRepository;
        private readonly Repository<CategoryModel> _repositoryCategory;

        public ValueController(UserRepository userRepository,Repository<CategoryModel> repositoryCategory)
        {
            this._userRepository = userRepository;
            this._repositoryCategory = repositoryCategory;
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
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

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}