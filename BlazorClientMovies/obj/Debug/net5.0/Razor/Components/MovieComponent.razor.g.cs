#pragma checksum "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Components\MovieComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c4c2dc99858cc9b9b48e2603bcc29a4027a131b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClientMovies.Components
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
    public partial class MovieComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card column is-4 test2");
            __builder.AddAttribute(2, "b-1850phwlgw");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-image");
            __builder.AddAttribute(5, "b-1850phwlgw");
            __builder.OpenElement(6, "figure");
            __builder.AddAttribute(7, "class", "is-4by3");
            __builder.AddAttribute(8, "b-1850phwlgw");
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 4 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Components\MovieComponent.razor"
                       movieImageUri

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "alt", "Placeholder image");
            __builder.AddAttribute(12, "b-1850phwlgw");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card-content");
            __builder.AddAttribute(16, "b-1850phwlgw");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "media");
            __builder.AddAttribute(19, "b-1850phwlgw");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "media-content");
            __builder.AddAttribute(22, "b-1850phwlgw");
            __builder.OpenElement(23, "p");
            __builder.AddAttribute(24, "class", "title is-4");
            __builder.AddAttribute(25, "b-1850phwlgw");
            __builder.AddContent(26, 
#nullable restore
#line 10 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Components\MovieComponent.razor"
                                       movie.original_title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "content");
            __builder.AddAttribute(30, "b-1850phwlgw");
            __builder.AddContent(31, 
#nullable restore
#line 14 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Components\MovieComponent.razor"
             movie.overview

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "time");
            __builder.AddAttribute(34, "datetime");
            __builder.AddAttribute(35, "b-1850phwlgw");
            __builder.AddContent(36, 
#nullable restore
#line 15 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Components\MovieComponent.razor"
                               movie.release_date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Components\MovieComponent.razor"
       
    [Parameter]
    public Models.Movie movie { get; set; }

    [Parameter]
    public string movieImageBaseUri { get; set; }

    private string movieImageUri
    {
        get { return movieImageBaseUri + movie.poster_path; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
