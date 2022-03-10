import { Component, ElementRef, ViewChild } from '@angular/core';
import { Movie } from '../interfaces/movies.interface';
import { MovieService } from '../service/movie.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styles: []
})
export class SearchComponent  {

  @ViewChild('txtSearch', {static: false}) txtSearch!: ElementRef<HTMLInputElement>;
  private _moviesSearched : Movie[] = []
  noData: boolean = false;
  valueSearched: string = ''

  constructor(private movieService: MovieService) { }

  get moviesSearched(){
    return [...this._moviesSearched]
  }

  set moviesSearched(data: Movie[]){
    this._moviesSearched = data;
  }

  search(){
      const value = this.txtSearch.nativeElement.value;

      if(value.trim().length === 0)      
        return;
      this.valueSearched = value;
      this.noData = false;
      this.movieService.searchMovies(value)
        .subscribe((resp) => {
          this.moviesSearched = resp
          console.log(resp)
      }, (err) => {
        this.noData = true;
        this.moviesSearched = []
      });

      this.txtSearch.nativeElement.value = "";
  }

  showDetail(id:number){
    this.movieService.redirectToDetail(id.toString())
  }
  
}
