import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DetailMovie } from '../../interfaces/movies.interface';
import { MovieService } from '../../service/movie.service';

@Component({
  selector: 'app-detail-movie',
  templateUrl: './detail-movie.component.html',
  styles: []
})
export class DetailMovieComponent implements OnInit{

  constructor(private movieService: MovieService, private activateRoute: ActivatedRoute) { }

  public detailMovie: DetailMovie= {
    budget: 0,
    genres: [],
    id: 0,
    overview: '',
    popularity: 0,
    posterPath: '',
    productionCompanies: [],
    releaseDate: undefined,
    runtime: 0,
    status: '',
    title: '',
    voteAverage: 0,
    voteCount: 0
  };

  ngOnInit(): void {
    this.activateRoute.params
      .subscribe(({id}) => {
        this.getDetails(id)
        console.log(id);

      })
  }

  getDetails(id:string){
    this.movieService.getDetailMovie(id)
      .subscribe((resp) => {
        this.detailMovie = resp;
        console.log(resp)
      })
  }

}
