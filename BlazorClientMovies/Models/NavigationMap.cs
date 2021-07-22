using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClientMovies.Models
{
    public static class NavigationMap
    {
        public static List<Navigation> Navigations { get; set; } = new List<Navigation>();

        static NavigationMap()
        {
            Navigations.Add(new Navigation() { Title = "Home", Path = "" });
            Navigations.Add(new Navigation() { Title = "Top rated movies", Path = "top-rated" });
            Navigations.Add(new Navigation() { Title = "Slow loading page", Path = "slow-loading" });
        }
    }

    public class Navigation
    {
        public string Title { get; set; }
        public string Path { get; set; }
        public List<Navigation> Children { get; set; }
    }
}
