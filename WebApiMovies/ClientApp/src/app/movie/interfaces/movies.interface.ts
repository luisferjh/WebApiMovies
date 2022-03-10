export interface SearchMoviesRespons {
    page:          number;
    results:       Movie[];
    // total_pages:   number;
    // total_results: number;
}

export interface Movie {
    id:                number;
    overview:          string;
    popularity:        number;
    posterPath:       string;
    releaseDate:      Date;
    title:             string;
    voteAverage:      number;
    voteCount:        number;
}

export interface DetailMovie {
    budget:                number;
    genres:                Genre[];
    id:                    number;
    overview:              string;
    popularity:            number;
    posterPath:           string;
    productionCompanies:  ProductionCompany[];
    releaseDate:          Date;
    runtime:               number;
    status:                string;
    title:                 string;
    voteAverage:          number;
    voteCount:            number;
}

export interface Genre {
    id:   number;
    name: string;
}

export interface ProductionCompany {
    id:             number;
    logoPath:      null | string;
    name:           string;
}



