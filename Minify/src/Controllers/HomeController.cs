using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Minify.Controllers
{
    [Controller]
    [Route("/redirect")]
    public class RedirectController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Redirect("https://www.google.com");
        }
    }
}