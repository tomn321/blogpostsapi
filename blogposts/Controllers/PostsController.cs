using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blogposts.Controllers.models;
using Microsoft.AspNetCore.Mvc;

namespace blogposts.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PostsController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            return new Post[] { new Post{
                UserId = 1,
                Id = 1,
                Title = "First test post",
                Body = "This post\nis a test\non my new site."
             }};
        }

      
    }
}
