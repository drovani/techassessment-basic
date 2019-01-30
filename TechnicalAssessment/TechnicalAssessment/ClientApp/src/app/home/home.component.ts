import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'
})
export class HomeComponent {
  public blogposts: BlogPost[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<BlogPost[]>(baseUrl + 'api/Home/BlogPosts').subscribe(result => {
      this.blogposts = result;
    }, error => console.error(error));
  }
}

interface BlogPost {
  title: string;
  postedBy: string;
  postedOn: Date;
  bodyText: string;
}
