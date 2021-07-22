using BlazorClientMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClientMovies.Services
{
    public interface IMovieDataService
    {
        Task<MoviePage> GetTopRatedMoviePage(int pageNo);
    }
}
