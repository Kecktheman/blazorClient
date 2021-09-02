#pragma checksum "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Pages\ComponentLifecycle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b903f65c566ba8729784e19117e05de9a6e9f997"
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
#line 10 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\_Imports.razor"
using BlazorClientMovies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\_Imports.razor"
using BlazorClientMovies.Services;

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
using BlazorClientMovies.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\_Imports.razor"
using BlazorClientMovies.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/component-lifecycle")]
    public partial class ComponentLifecycle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Component lifecycle</h1>\r\n\r\n<br><br>");
#nullable restore
#line 7 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Pages\ComponentLifecycle.razor"
 foreach (var item in LifeCycleEvents)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.OpenElement(2, "code");
            __builder.AddContent(3, 
#nullable restore
#line 10 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Pages\ComponentLifecycle.razor"
           item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    <br>");
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Pages\ComponentLifecycle.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<br><br>\r\n");
            __builder.AddMarkupContent(6, "<a href=\"https://executecommands.com/aspcore-blazor-lifecycle-methods/\" target=\"_blank\">https://executecommands.com/aspcore-blazor-lifecycle-methods/</a>");
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\msjolin\source\repos\BlazorClientMovies\BlazorClientMovies\Pages\ComponentLifecycle.razor"
       
    public List<string> LifeCycleEvents = new List<string>();

    protected override void OnInitialized()
    {
        LifeCycleEvents.Add("OnInitialized()");
    }

    protected override async Task OnInitializedAsync()
    {
        LifeCycleEvents.Add("OnInitializedAsync()");
        await Task.Delay(500);
    }

    protected override void OnParametersSet()
    {
        LifeCycleEvents.Add("OnParametersSet()");
    }

    protected override async Task OnParametersSetAsync()
    {
        LifeCycleEvents.Add("OnParametersSetAsync()");
        await Task.Delay(500);
    }

    protected override void OnAfterRender(bool firstRender)
    {
        LifeCycleEvents.Add("OnAfterRender()");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        LifeCycleEvents.Add("OnAfterRenderAsync()");
        await Task.Delay(500);
    }

    protected override bool ShouldRender()
    {
        LifeCycleEvents.Add("ShouldRender()");
        return true;
    }

    public override async Task SetParametersAsync(ParameterView parameters)
    {
        LifeCycleEvents.Add("SetParametersAsync()");
        await base.SetParametersAsync(parameters);
        await Task.Delay(500);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591