using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TechnicalAssessment.DataServices;

namespace TechnicalAssessment.Controllers
{
    [Route("api/[controller]")]
    public partial class BlogPostsController : ControllerBase
    {
        private readonly BloggingContext _context;

        public BlogPostsController(BloggingContext context) => _context = context;

        [HttpGet]
        public ActionResult<IEnumerable<BlogPost>> GetBlogPosts()
        {
            return Ok(new BlogPostService(_context).GetBlogPosts());
        }
        [HttpGet("{id}")]
        public ActionResult<BlogPost> GetBlogPost(Guid id)
        {
            BlogPost post = new BlogPostService(_context).GetBlogPost(id);
            if (post == default(BlogPost))
            {
                return NotFound();
            }
            else
            {
                return Ok(post);
            }
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteBlogPost(Guid id)
        {
            new BlogPostService(_context).DeleteBlogPost(id);
            return NoContent();
        }
        [HttpPost]
        public ActionResult<BlogPost> PostBlogPost(BlogPost newPost)
        {
            new BlogPostService(_context).CreateBlogPost(newPost);
            return CreatedAtAction(nameof(GetBlogPost), new { id = newPost.Id }, newPost);
        }
    }
}
