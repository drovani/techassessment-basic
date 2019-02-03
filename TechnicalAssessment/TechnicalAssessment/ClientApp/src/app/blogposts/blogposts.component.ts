import { Component, OnInit } from '@angular/core';
import { BlogPost } from '../blogpost';
import { BlogPostService } from '../blogpost.service';

@Component({
  selector: 'app-blogposts',
  templateUrl: './blogposts.component.html'
})
export class BlogPostsComponent implements OnInit {
  public blogposts: BlogPost[];

  constructor(private blogpostService: BlogPostService) { }

  ngOnInit() {
    this.getBlogPosts();
  }

  getBlogPosts(): void {
    this.blogpostService.getBlogPosts()
      .subscribe(blogposts => this.blogposts = blogposts);
  }
}
