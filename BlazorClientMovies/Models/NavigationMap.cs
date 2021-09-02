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

            Navigations.Add(new Navigation() { Title = "Counter", Path = "counter" });
            Navigations.Add(new Navigation() { Title = "Counter separated", Path = "counter-separated" });

            Navigations.Add(new Navigation() { Title = "Attribute parameters", Path = "attribute-parameters" });
            Navigations.Add(new Navigation() { Title = "Route parameters", Path = "parameters" });
            Navigations.Add(new Navigation() { Title = "Optional route parameters", Path = "optional-parameters" });
            Navigations.Add(new Navigation() { Title = "Cascading parameters", Path = "cascading-parameters" });
            Navigations.Add(new Navigation() { Title = "Cascading multiple", Path = "multiple-cascading-parameters" });

            Navigations.Add(new Navigation() { Title = "Component lifecycle", Path = "component-lifecycle" });
            Navigations.Add(new Navigation() { Title = "Data bindings", Path = "data-bindings" });
            Navigations.Add(new Navigation() { Title = "Javascript?", Path = "javascript" });

            Navigations.Add(new Navigation() { Title = "Top rated movies", Path = "top-rated" });
        }
    }

    public class Navigation
    {
        public string Title { get; set; }
        public string Path { get; set; }
        public List<Navigation> Children { get; set; }
    }
}
