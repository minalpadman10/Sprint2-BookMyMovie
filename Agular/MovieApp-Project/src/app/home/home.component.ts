import { Component, OnInit } from '@angular/core';
import { Movie } from '../models/Movie';
import { MovieService } from '../services/movie.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private _movieservice: MovieService) { }

  movies: Array<Movie> = new Array<Movie>();
  ngOnInit(): void {

    this._movieservice.getMovies().subscribe(res => this.movies = res, err => console.log(err))
  }

}