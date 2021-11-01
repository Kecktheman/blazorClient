#pragma checksum "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Pages\DataBindings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "315abf1c20be3b76889d4ef32f458c75c1ef1635"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/data-bindings")]
    public partial class DataBindings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Data bindings</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "<h4>Default bind event</h4>\r\n\r\n    ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Pages\DataBindings.razor"
                  InputValue1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => InputValue1 = __value, InputValue1));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddMarkupContent(8, "<code>InputValue1</code>: ");
            __builder.AddContent(9, 
#nullable restore
#line 11 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Pages\DataBindings.razor"
                                   InputValue1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n\r\n");
            __builder.OpenElement(11, "p");
            __builder.AddMarkupContent(12, "<h4>Bind specific event \"oninput\"</h4>\r\n\r\n    ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Pages\DataBindings.razor"
                  InputValue2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => InputValue2 = __value, InputValue2));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Pages\DataBindings.razor"
                      ClearInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Clear");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddMarkupContent(22, "<code>InputValue2</code>: ");
            __builder.AddContent(23, 
#nullable restore
#line 23 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Pages\DataBindings.razor"
                                   InputValue2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n\r\n");
            __builder.OpenElement(25, "p");
            __builder.AddMarkupContent(26, "<h4>Capture event args</h4>\r\n\r\n    ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Pages\DataBindings.razor"
                                                                  CaptureKeyInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Pages\DataBindings.razor"
                  InputValue3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => InputValue3 = __value, InputValue3));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Pages\DataBindings.razor"
                      CaptureMouseInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Click me!");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n    ");
            __builder.OpenElement(36, "div");
            __builder.AddMarkupContent(37, "<code>InputValue3Result</code>: ");
            __builder.AddContent(38, 
#nullable restore
#line 35 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Pages\DataBindings.razor"
                                         InputValue3Result

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Pages\DataBindings.razor"
       
    private string InputValue1;

    private string InputValue2;

    private string InputValue3, InputValue3Result;


    private void ClearInput()
    {
        InputValue2 = String.Empty;
    }

    private void CaptureKeyInput(KeyboardEventArgs e)
    {
        InputValue3Result += e.Code.ToString();
        InputValue3 = String.Empty;
    }

    private void CaptureMouseInput(MouseEventArgs e)
    {
        InputValue3Result += e.Button.ToString();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
