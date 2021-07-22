#pragma checksum "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Pages\MoviesTopRated.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6efc0500163e0646a8c467cea049654e795869ed"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClientMovies.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\_Imports.razor"
using BlazorClientMovies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\_Imports.razor"
using BlazorClientMovies.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\_Imports.razor"
using BlazorClientMovies.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\_Imports.razor"
using BlazorClientMovies.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\_Imports.razor"
using BlazorClientMovies.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/top-rated")]
    public partial class MoviesTopRated : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Top rated movies</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "columns is-multiline");
#nullable restore
#line 6 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Pages\MoviesTopRated.razor"
     if (isLoading)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorClientMovies.Shared.Loader>(3);
            __builder.CloseComponent();
#nullable restore
#line 9 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Pages\MoviesTopRated.razor"
    }
    else
    {
        foreach (var movie in moviePage.results)
        {
            if (movie != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorClientMovies.Components.MovieComponent>(4);
            __builder.AddAttribute(5, "movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorClientMovies.Models.Movie>(
#nullable restore
#line 16 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Pages\MoviesTopRated.razor"
                                        movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "movieImageBaseUri", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Pages\MoviesTopRated.razor"
                                                                   movieImageBaseUri

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 17 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Pages\MoviesTopRated.razor"
            }
        }
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591