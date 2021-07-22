using BlazorClientMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorClientMovies.Services
{
    public class MovieDataService : IMovieDataService
    {
        HttpClient httpClient = new HttpClient();

        public async Task<MoviePage> GetTopRatedMoviePage(int pageNo)
        {
            var result = new MoviePage();

            try
            {
                result = await httpClient.GetFromJsonAsync<MoviePage>("https://api.themoviedb.org/3/movie/top_rated?api_key=67a96a5052d3cf9da71ea15dce3f94aa&language=en-US&page=1");

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            return result;
        }
    }
}
