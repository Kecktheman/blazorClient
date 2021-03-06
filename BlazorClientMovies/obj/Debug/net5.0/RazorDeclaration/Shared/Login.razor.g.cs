// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\msjolin\repos\blazorClient\BlazorClientMovies\Shared\Login.razor"
       
    [Parameter]
    public User User { get; set; } = new User();

    [Parameter]
    public EventCallback<User> UserChanged { get; set; }

    protected bool ShowLogin { get; set; }



    protected override async Task OnInitializedAsync()
    {
        var currentUserEmail = await JSRuntime.InvokeAsync<string>("localStorage.getItem", "userEmail");

        if (String.IsNullOrEmpty((string)currentUserEmail) == false)
        {
            ShowLogin = false;
        }
        else
        {
            ShowLogin = true;
        }

        base.StateHasChanged();
    }

    private async Task HandleValidLogin()
    {
        await JSRuntime.InvokeVoidAsync("localStorage.setItem", "userEmail", User.Email);

        ShowLogin = false;

        // Updates data in parent component (two way binding) - not working with StateHasChanged()
        await UserChanged.InvokeAsync(User);
    }

    private void HandleInvalidLogin()
    {
        // Error message etc.
    }

    public async Task HandleLogout()
    {
        await JSRuntime.InvokeVoidAsync("localStorage.removeItem", "userEmail");

        ShowLogin = true;

        base.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
