using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

using BlazorClientMovies.Models;
using BlazorClientMovies.Services;

namespace BlazorClientMovies.Pages
{
    public partial class MoviesTopRated : ComponentBase
    {
        private MovieDataService movieDataService = new MovieDataService();

        protected MoviePage moviePage { get; set; } = new MoviePage();
        protected bool isLoading { get; set; }
        protected string movieImageBaseUri { get; set; } = "https://image.tmdb.org/t/p/original";



        protected override async Task OnInitializedAsync()
        {
            moviePage.results = new List<Movie>();
            isLoading = true;

            try
            {
                moviePage = await movieDataService.GetTopRatedMoviePage(1);
                isLoading = false;
            }
            catch
            {
                Console.WriteLine("Could not get top rated movies. Please try again.");
            }
        }
    }
}