#pragma checksum "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4465fe17aad66a52af16e0c0eff383e2d8595ce"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-n9o218qhqe");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-n9o218qhqe>BlazorClientMovies</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-n9o218qhqe");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-n9o218qhqe></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n\r\n");
            __builder.OpenComponent<Blazorise.Button>(10);
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Shared\NavMenu.razor"
                   HandleLogout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(13, "Logout");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n\r\n\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", 
#nullable restore
#line 13 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "b-n9o218qhqe");
            __builder.OpenElement(19, "ul");
            __builder.AddAttribute(20, "class", "nav flex-column");
            __builder.AddAttribute(21, "b-n9o218qhqe");
#nullable restore
#line 16 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Shared\NavMenu.razor"
         foreach (Navigation navigation in NavigationMap.Navigations)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "li");
            __builder.AddAttribute(23, "class", "nav-item px-3");
            __builder.AddAttribute(24, "b-n9o218qhqe");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(25);
            __builder.AddAttribute(26, "class", "nav-link");
            __builder.AddAttribute(27, "href", 
#nullable restore
#line 19 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Shared\NavMenu.razor"
                                                 navigation.Path

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 19 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Shared\NavMenu.razor"
                                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(30, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-n9o218qhqe></span> ");
                __builder2.AddContent(31, 
#nullable restore
#line 20 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Shared\NavMenu.razor"
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
#line 23 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Shared\NavMenu.razor"
       

    [Parameter]
    public Login Login { get; set; }

    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "" : null;

    //private string displayEmail
    //{
    //    get
    //    {
    //        if (Login != null && Login.User != null)
    //        {
    //            StateHasChanged();
    //            return Login.User.Email;
    //        }
    //        else
    //            return "no email found";
    //    }
    //}

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    public void HandleLogout()
    {
        Console.WriteLine("logout");
        if (Login != null)
        {
            Login.HandleLogout();
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
