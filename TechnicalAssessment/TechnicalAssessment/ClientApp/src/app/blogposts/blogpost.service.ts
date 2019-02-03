import { Injectable } from '@angular/core'
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';

import { BlogPost } from './blogpost';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable({
  providedIn: 'root',
})

export class BlogPostService {
  private blogPostsUrl = 'api/BlogPosts';

  constructor(protected http: HttpClient) { }

  getBlogPosts(): Observable<BlogPost[]> {

    return this.http.get<BlogPost[]>(this.blogPostsUrl)
      .pipe(
        catchError(this.handleError('getBlogPosts', []))
      );
  }

  createBlogPost(blogpost: BlogPost): Observable<BlogPost> {
    return this.http.post<BlogPost>(this.blogPostsUrl, blogpost, httpOptions)
      .pipe(
        catchError(this.handleError<BlogPost>('createBlogPost'))
      );
  }

  deleteBlogPost(blogpost: BlogPost | string): Observable<BlogPost> {
    const id = typeof blogpost === 'string' ? blogpost : blogpost.id;
    const url = `${this.blogPostsUrl}/${id}`;

    return this.http.delete<BlogPost>(url, httpOptions)
      .pipe(
        catchError(this.handleError<BlogPost>('deleteBlogPost'))
      );
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error);
      return of(result as T);
    };
  }
}
