using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reddit.Models;

namespace Reddit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        [HttpGet]
        public List<Post> GetPosts() {
        
        }
    }
}
