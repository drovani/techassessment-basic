using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        [HttpDelete]
        public void DeleteBlogPost(Guid id)
        {
            new BlogPostService().DeleteBlogPost(id);
        }
        [HttpPost]
        public void CreateBlogPost(BlogPost newPost)
        {
            new BlogPostService().CreateBlogPost(newPost);
        }
    }
}
