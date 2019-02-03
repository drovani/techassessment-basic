using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TechnicalAssessment.DataServices;

namespace TechnicalAssessment.Controllers
{
    [Route("api/[controller]")]
    public partial class BlogPostsController : Controller
    {
        [HttpGet]
        public IEnumerable<BlogPost> GetBlogPosts()
        {
            return new BlogPostService().BlogPosts;
        }
        [HttpDelete]
        public void DeleteBlogPost(Guid id)
        {
            new BlogPostService().DeleteBlogPost(id);
        }
        [HttpPost]
        public void PostBlogPost(BlogPost newPost)
        {
            new BlogPostService().CreateBlogPost(newPost);
        }
    }
}
