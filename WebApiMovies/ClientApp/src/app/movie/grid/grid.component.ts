import { Component, Input, OnInit } from '@angular/core';
import { Movie } from '../interfaces/movies.interface';


@Component({
  selector: 'app-grid',
  templateUrl: './grid.component.html',
  styles: [`
    .title-color{
      background-color:#094D90;
    }
  `]
})
export class GridComponent implements OnInit{

  // @Input() dataMovies: Movie[] = [];
  @Input() dataMovies: Movie;

  constructor() {}

  ngOnInit(): void {
    console.log(this.dataMovies)
    
  }

 


}
