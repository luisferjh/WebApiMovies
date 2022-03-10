import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Movie } from '../../interfaces/movies.interface';
import { MovieService } from '../../service/movie.service';

@Component({
  selector: 'app-top-rates',
  templateUrl: './top-rates.component.html',
  styles: []
})
export class TopRatesComponent {

  private _moviesTopRates : Movie[] = []

  constructor(private movieService: MovieService, private route:Router) {
    this.movieService.TopRatedMovies().subscribe((resp) => {
      this._moviesTopRates = resp;
      console.log(resp)
    })
  }

  get moviesTopRates(){
    return [...this._moviesTopRates]
  }

  set moviesTopRates(data: Movie[]){
      this._moviesTopRates = data
  }
  
  showDetail(id:number){
    this.movieService.redirectToDetail(id.toString())
  }
  
}
