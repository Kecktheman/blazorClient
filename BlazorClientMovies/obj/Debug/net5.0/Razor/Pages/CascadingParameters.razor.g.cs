#pragma checksum "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Pages\CascadingParameters.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "308a091deeba0e5b4b70b11152c8769b9db164b2"
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
#line 1 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\_Imports.razor"
using BlazorClientMovies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\_Imports.razor"
using BlazorClientMovies.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\_Imports.razor"
using BlazorClientMovies.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\_Imports.razor"
using BlazorClientMovies.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\_Imports.razor"
using BlazorClientMovies.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cascading-parameters")]
    public partial class CascadingParameters : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Cascading parameters</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "<code>CascadedString:</code>");
            __builder.AddContent(3, 
#nullable restore
#line 6 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Pages\CascadingParameters.razor"
                                 CascadedString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Pages\CascadingParameters.razor"
       
    [Parameter]
    public string Parameter { get; set; }

    [CascadingParameter]
    protected string CascadedString { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
