import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Movie, DetailMovie } from '../interfaces/movies.interface';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class MovieService {

  private serviceUrl: string = 'http://localhost:44890/api/movie'
  private results:any = []


  constructor(private http: HttpClient, private route:Router) {}

  listMovies()
  {    
    return this.http.get<Movie[]>(`${this.serviceUrl}/OnTheather`)      
  }

  
  TopRatedMovies()
  {    
    return this.http.get<Movie[]>(`${this.serviceUrl}/TopRates`)      
  }

  PopularMovies()
  {    
    return this.http.get<Movie[]>(`${this.serviceUrl}/TopPopular`)      
  }


  searchMovies(query: string = '')
  {
    query = query.trim()

    return this.http.get<Movie[]>(`${this.serviceUrl}/SearchMovies/${query}`)     
  }
  getDetailMovie(id: string = '')
  {
    return this.http.get<DetailMovie>(`${this.serviceUrl}/GetMovieDetail/${id}`)     
  }
  
  redirectToDetail( id:string){
    console.log('redirect')   
    console.log(id)
    this.route.navigate([`/movie/detail/${id}`])
  }
}
