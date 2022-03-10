import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { OnTheatherComponent } from './pages/on-theather/on-theather.component';
import { TopRatesComponent } from './pages/top-rates/top-rates.component';
import { PopularComponent } from './pages/popular/popular.component';
import { DetailMovieComponent } from './pages/detail-movie/detail-movie.component';
import { SearchComponent } from './search/search.component';
import { GridComponent } from './grid/grid.component';



@NgModule({
  declarations: [
    OnTheatherComponent, 
    TopRatesComponent, 
    PopularComponent, 
    DetailMovieComponent, 
    SearchComponent, GridComponent],
  imports: [
    CommonModule,

  ],
  exports:[    
    OnTheatherComponent, 
    TopRatesComponent, 
    PopularComponent, 
    DetailMovieComponent
  ]
})
export class MovieModule { }
