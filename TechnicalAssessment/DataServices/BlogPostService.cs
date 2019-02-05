using System;
using System.Collections.Generic;
using System.Linq;

namespace TechnicalAssessment.DataServices
{
    public class BlogPostService
    {
        private BloggingContext _context;

        public BlogPostService(BloggingContext context) => _context = context;

        public IEnumerable<BlogPost> GetBlogPosts()
        {
            return _context.BlogPosts.OrderByDescending(d => d.PostedOn).AsEnumerable();
        }
        public BlogPost GetBlogPost(Guid id)
        {
            return _context.BlogPosts.SingleOrDefault(post => post.Id == id);
        }
        public void DeleteBlogPost(Guid id)
        {
            _context.Remove(_context.BlogPosts.SingleOrDefault(post => post.Id == id));
            _context.SaveChanges();
        }
        public void CreateBlogPost(BlogPost newPost)
        {
            _context.Add(newPost);
            _context.SaveChanges();
        }

        public static void SeedBlogPosts(BloggingContext context)
        {
            context.AddRange(new BlogPost[]
            {
                new BlogPost
                {
                    Id = Guid.Parse("8da47810-ced4-4a48-adff-d0f83080c9f7"),
                    Title = "Stuff About Running",
                    PostedBy = "drovani",
                    PostedOn = DateTime.UtcNow.AddDays(-1),
                    BodyText = @"Road running takes place on a measured course over an established road (as opposed to track and cross country running). These events normally range from distances of 5 kilometers to longer distances such as half marathons and marathons, and they may involve scores of runners or wheelchair entrants. Cross country running takes place over the open or rough terrain. The courses used for these events may include grass, mud, woodlands, hills, flat ground and water. It is a popular participatory sport and is one of the events which, along with track and field, road running, and racewalking, makes up the umbrella sport of athletics."
                },
                new BlogPost
                {
                    Id = Guid.Parse("a61e06ec-505c-4a2f-a86f-77e4c8ac8312"),
                    Title = "Cooking History",
                    PostedBy = "inavord",
                    PostedOn = DateTime.UtcNow.AddDays(-7),
                    BodyText = @"In the seventeenth and eighteenth centuries, food was a classic marker of identity in Europe. In the nineteenth-century ""Age of Nationalism"" cuisine became a defining symbol of national identity. The Industrial Revolution brought mass-production, mass-marketing and standardization of food. Factories processed, preserved, canned, and packaged a wide variety of foods, and processed cereals quickly became a defining feature of the American breakfast. In the 1920s, freezing methods, cafeterias and fast food restaurants emerged."
                },
                new BlogPost
                {
                    Id = Guid.Parse("1a4745d0-b6bc-4c3f-a1a8-81807b03fd07"),
                    Title = "Obligatory Lorem Ipsum",
                    PostedBy = "Cicero",
                    PostedOn = DateTime.UtcNow.AddDays(-14),
                    BodyText = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Mi tempus imperdiet nulla malesuada. Eleifend donec pretium vulputate sapien nec sagittis aliquam malesuada bibendum. Scelerisque felis imperdiet proin fermentum leo. Mauris nunc congue nisi vitae. Sed viverra tellus in hac habitasse platea dictumst vestibulum rhoncus. Vitae purus faucibus ornare suspendisse sed nisi. Curabitur gravida arcu ac tortor dignissim convallis aenean et. Hac habitasse platea dictumst quisque. Nulla malesuada pellentesque elit eget gravida cum. Dictumst quisque sagittis purus sit amet volutpat consequat. Condimentum lacinia quis vel eros. Sem integer vitae justo eget magna fermentum iaculis eu. Luctus venenatis lectus magna fringilla urna porttitor rhoncus dolor. Turpis massa tincidunt dui ut ornare lectus sit. Tortor consequat id porta nibh venenatis cras sed felis. Ut ornare lectus sit amet est placerat in egestas. Leo integer malesuada nunc vel risus. Senectus et netus et malesuada fames ac turpis egestas maecenas. Risus pretium quam vulputate dignissim suspendisse. Nunc sed velit dignissim sodales ut. Donec enim diam vulputate ut pharetra sit amet aliquam id. Scelerisque fermentum dui faucibus in. Dolor purus non enim praesent elementum facilisis. Amet dictum sit amet justo donec enim diam vulputate ut. At tellus at urna condimentum. Volutpat diam ut venenatis tellus in metus vulputate eu. Ultrices sagittis orci a scelerisque. Fames ac turpis egestas integer eget aliquet."
                },
                new BlogPost
                {
                    Id = Guid.Parse("2ce40266-9310-4277-b315-9faa9286b567"),
                    Title = "Far far away",
                    PostedBy = "Blind Text",
                    PostedOn = DateTime.UtcNow.AddDays(-21),
                    BodyText = @"Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean. A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country, in which roasted parts of sentences fly into your mouth. Even the all-powerful Pointing has no control about the blind texts it is an almost unorthographic life One day however a small line of blind text by the name of Lorem Ipsum decided to"
                },
                new BlogPost
                {
                    Id = Guid.Parse("f2f9c903-dbbd-4318-97dc-c4a998ef1175"),
                    Title = "Corporate Ipsum",
                    PostedBy = "inavord",
                    PostedOn = DateTime.UtcNow.AddDays(-28),
                    BodyText = @"Leverage agile frameworks to provide a robust synopsis for high level overviews. Iterative approaches to corporate strategy foster collaborative thinking to further the overall value proposition. Organically grow the holistic world view of disruptive innovation via workplace diversity and empowerment. Bring to the table win-win survival strategies to ensure proactive domination. At the end of the day, going forward, a new normal that has evolved from generation X is on the runway heading towards a streamlined cloud solution. User generated content in real-time will have multiple touchpoints for offshoring."
                },
            });
            context.SaveChanges();
        }

    }
}
