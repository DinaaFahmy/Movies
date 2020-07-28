import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {Movie} from '../_models/movie'
@Injectable({
  providedIn: 'root'
})
export class MovieService {
  getMovies() {
    return this.http.get<Movie[]>('http://localhost:56844/api/movie');
  }
  getMovie(id:number) {
    return this.http.get<Movie>('http://localhost:56844/api/movie/'+id);
  }
  
  constructor(private http: HttpClient) { }
}

