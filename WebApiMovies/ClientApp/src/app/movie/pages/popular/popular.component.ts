import { Component } from '@angular/core';
import { Movie } from '../../interfaces/movies.interface';
import { MovieService } from '../../service/movie.service';

@Component({
  selector: 'app-popular',
  templateUrl: './popular.component.html',
  styles: []
})
export class PopularComponent  {

  private _popularMovies : Movie[] = []

  constructor(private movieService: MovieService) {
    this.movieService.PopularMovies().subscribe((resp) => {
      this._popularMovies = resp;
      console.log(resp)
    })
  }

  get popularMovies(){
    return [...this._popularMovies]
  }

  set popularMovies(data: Movie[]){
      this._popularMovies = data
  }

  
  showDetail(id:number){
    this.movieService.redirectToDetail(id.toString())
  }

}
