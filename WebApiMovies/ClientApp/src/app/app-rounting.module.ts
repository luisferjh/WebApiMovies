import {NgModule} from '@angular/core'
import { RouterModule, Routes } from '@angular/router'
import { OnTheatherComponent } from './movie/pages/on-theather/on-theather.component';
import { TopRatesComponent } from './movie/pages/top-rates/top-rates.component';
import { PopularComponent } from './movie/pages/popular/popular.component';
import { DetailMovieComponent } from './movie/pages/detail-movie/detail-movie.component';

const routes: Routes = [
    {
        path:'',
        component:OnTheatherComponent,
        pathMatch:'full'
    },
    {
        path:'toprated',
        component:TopRatesComponent,
    },
    {
        path:'popular',
        component:PopularComponent,
    },
    {
        path:'movie/detail/:id',
        component:DetailMovieComponent,
    },
    {
        path:'**',
        redirectTo:''
    },
]

@NgModule({
    imports:[
        RouterModule.forRoot(routes)
    ],
    exports:[
        RouterModule
    ]
})

export class AppRoutingModule {}