#pragma checksum "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83b19c0773beaf38bf9e44606e5ee084335508e4"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClientMovies.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 1 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 1 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "b-n9o218qhqe");
            __builder.OpenElement(4, "ul");
            __builder.AddAttribute(5, "class", "nav flex-column py-3");
            __builder.AddAttribute(6, "b-n9o218qhqe");
#nullable restore
#line 4 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Shared\NavMenu.razor"
         foreach (Navigation navigation in NavigationMap.Navigations)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "class", "nav-item px-3");
            __builder.AddAttribute(9, "b-n9o218qhqe");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(10);
            __builder.AddAttribute(11, "class", "nav-link");
            __builder.AddAttribute(12, "href", 
#nullable restore
#line 7 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Shared\NavMenu.razor"
                                                 navigation.Path

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 7 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Shared\NavMenu.razor"
                                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(15, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-n9o218qhqe></span> ");
                __builder2.AddContent(16, 
#nullable restore
#line 8 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Shared\NavMenu.razor"
                                                                         navigation.Title

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n    <br b-n9o218qhqe><br b-n9o218qhqe>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Shared\NavMenu.razor"
       
    [Parameter]
    public Login Login { get; set; }

    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
