using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Blazorise;
using Blazorise.Bulma;
using Blazorise.Icons.FontAwesome;

namespace BlazorClientMovies
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services
              .AddBlazorise(options =>
              {
                  options.ChangeTextOnKeyPress = true;
              })
              .AddBulmaProviders() // CSS ramverk
              .AddFontAwesomeIcons();

            // Tillåter [Inject] av HttpClient direkt i components
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
           
            builder.RootComponents.Add<App>("#app");

            await builder.Build().RunAsync();
        }
    }
}
