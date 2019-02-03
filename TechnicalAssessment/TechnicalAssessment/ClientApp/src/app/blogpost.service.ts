import { Injectable } from '@angular/core'
import { HttpClient } from '@angular/common/http';
import { BlogPost } from './blogpost';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';

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

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error);
      return of(result as T);
    };
  }
}
