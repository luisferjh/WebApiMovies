using AutoMapper;
using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using WebApiMovies.Models;

namespace WebApiMovies.Helpers
{
    public class AutoMapperProfile: Profile
    {
        private readonly CustomConfig conf;
        public AutoMapperProfile(CustomConfig config)
        {
            conf = config;

            CreateMap<Movie, MovieDTO>()
                .ForMember(dest => dest.PosterPath, opt => opt.MapFrom(src => $"{conf.baseUrl}{conf.customSize}{src.poster_path}"))
                .ForMember(dest => dest.ReleaseDate, opt => {
                    opt.PreCondition(src => (!string.IsNullOrEmpty(src.release_date)));
                    opt.MapFrom(src => DateTime.ParseExact(src.release_date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture));
                });
            CreateMap<Genre, GenreDTO>();
            CreateMap<ProductionCompany, ProductionCompanyDTO>()
                 .ForMember(dest => dest.LogoPath, opt => opt.MapFrom(src => src.logo_path));
            CreateMap<MovieDetail, MovieDetailsDTO>()
                .ForMember(dest => dest.PosterPath, opt => opt.MapFrom(src => $"{conf.baseUrl}{conf.originalSize}{src.poster_path}"))
                .ForMember(dest => dest.VoteAverage, opt => opt.MapFrom(src => src.vote_average))
                .ForMember(dest => dest.VoteCount, opt => opt.MapFrom(src => src.vote_count))
                .ForMember(dest => dest.ProductionCompanies, opt => opt.MapFrom(src => src.production_companies))
                .ForMember(dest => dest.ReleaseDate, opt => {
                     opt.PreCondition(src => (!string.IsNullOrEmpty(src.release_date)));
                     opt.MapFrom(src => DateTime.ParseExact(src.release_date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture));
                }); 
        }
    }
}
