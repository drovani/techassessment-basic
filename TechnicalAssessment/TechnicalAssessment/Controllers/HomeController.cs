using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechnicalAssessment.DataServices;

namespace TechnicalAssessment.Controllers
{
    [Route("api/[controller]")]
    public partial class HomeController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<BlogPost> BlogPosts()
        {
            return new BlogPostService().BlogPosts;
        }
    }
}
