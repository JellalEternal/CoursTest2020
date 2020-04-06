using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Minify.Model;

namespace Minify.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MinifyController : ControllerBase
    {
        [HttpPost]
        public string Add([FromBody] MinifyData data)
        {
            MongoRepository mongoRepository = new MongoRepository();
            data.Key = "aaa";
            mongoRepository.Add(data);
            return string.Empty;
        }

        [HttpGet]
        public IEnumerable<MinifyData> Get()
        {
            return new MinifyData[0];
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
        }
    }
}