import { Component } from '@angular/core';
import { Movie } from '../../interfaces/movies.interface';
import { MovieService } from '../../service/movie.service';

@Component({
  selector: 'app-on-theather',
  templateUrl: './on-theather.component.html',
  styles: []
})
export class OnTheatherComponent  {

  private _moviesOnTheather : Movie[] = []

  constructor(private movieService: MovieService) {
    this.movieService.listMovies()
    .subscribe((resp) => {
      this._moviesOnTheather = resp;
    })
  }

  get moviesOnTheater(){
    return [...this._moviesOnTheather]
  }

  set moviesOnTheater(data: Movie[]){
      this._moviesOnTheather = data
  }

  showDetail(id:number){
    this.movieService.redirectToDetail(id.toString())
  }

}
