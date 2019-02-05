import { Component, OnInit } from '@angular/core';
import { BlogPost } from './blogpost';
import { BlogPostService } from './blogpost.service';

@Component({
  selector: 'app-blogposts',
  templateUrl: './blogposts.component.html'
})
export class BlogPostsComponent implements OnInit {
  public blogposts: BlogPost[];
  public newBlogPost: BlogPost;

  constructor(private blogpostService: BlogPostService) {
    this.newBlogPost = new BlogPost('Test Blog Title', 'Seeded Author', 'This is some sample text so it doesn\'t need to be asdf\'d every time.');
  }

  ngOnInit() {
    this.getBlogPosts();
  }

  getBlogPosts(): void {
    this.blogpostService.getBlogPosts()
      .subscribe(blogposts => this.blogposts = blogposts);
  }

  onSubmit(): void {
    this.blogpostService.createBlogPost(this.newBlogPost)
      .subscribe(post => {
        this.blogposts.unshift(post);
        this.newBlogPost = new BlogPost();
      });
  }

  resetBlogPost(): void {
    this.newBlogPost = new BlogPost();
  }

  delete(blogpost: BlogPost): void {
    this.blogposts = this.blogposts.filter(bp => bp !== blogpost);
    this.blogpostService.deleteBlogPost(blogpost).subscribe();
  }
}
