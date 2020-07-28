import { Component, OnInit } from '@angular/core';
import {MovieService} from '../_services/movie.service';
import {Movie} from '../_models/movie';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.css']
})
export class MovieComponent implements OnInit {
  m:Movie[];
  movie:Movie;
  id:number;
  constructor(private m_serv: MovieService) { }

  ngOnInit(): void {
    this.m_serv.getMovies().subscribe((a) => {
    this.m = a;
    console.log(a);
  });

  }
  details(e){
    this.m_serv.getMovie(e.value).subscribe((a)=>{
      this.movie=a;
      console.log(a);
      alert("Movie Name: "+a.movie_name +", Genre: "+a.genre);
    })
  }
}
