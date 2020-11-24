#pragma checksum "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94275937bef2fa13ee254892d56b9db26bcc499f"
// <auto-generated/>
#pragma warning disable 1591
namespace PlanetaGundam.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\_Imports.razor"
using PlanetaGundam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\_Imports.razor"
using PlanetaGundam.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(BlankLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.AddAttribute(1, "class", "form-signin w-100 p-2 m-auto");
            __builder.AddAttribute(2, "style", "max-width:330px");
            __builder.AddAttribute(3, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 6 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Login.razor"
                                                                              Authenticate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "\r\n    <img class=\"mb-4\" src=\"https://planetagundam.com/logo.png\" alt width=\"72\" height=\"72\">\r\n    ");
            __builder.AddMarkupContent(5, "<h1 class=\"h3 mb-3 font-weight-normal\">Please sign in</h1>\r\n    ");
            __builder.AddMarkupContent(6, "<label for=\"inputEmail\" class=\"sr-only\">PSN ID</label>\r\n    ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "placeholder", "PSN ID");
            __builder.AddAttribute(11, "required", true);
            __builder.AddAttribute(12, "autofocus", true);
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Login.razor"
                  PsnId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => PsnId = __value, PsnId));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.AddMarkupContent(16, "<label for=\"inputPassword\" class=\"sr-only\">Password</label>\r\n    ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "password");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "placeholder", "Password");
            __builder.AddAttribute(21, "required", true);
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Login.razor"
                  Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Password = __value, Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.AddMarkupContent(25, "<button type=\"submit\" class=\"btn btn-lg btn-primary btn-block\">\r\n        Sign in\r\n    </button>\r\n    ");
            __builder.AddMarkupContent(26, "<p class=\"mt-5 mb-3 text-muted\">© Planeta Gundam 2017-2020</p>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.OpenElement(28, "p");
            __builder.AddAttribute(29, "style", "color:red");
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 19 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Login.razor"
     if (!String.IsNullOrWhiteSpace(ErrorMessage))
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, 
#nullable restore
#line 21 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Login.razor"
         ErrorMessage

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 21 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Login.razor"
                     
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Login.razor"
       

    public List<Member> Members { get; set; } = new List<Member>();

    public string PsnId { get; set; }

    public string Password { get; set; }

    public string ErrorMessage { get; set; }

    protected override async Task OnInitializedAsync()
    {

        Members = await JSRuntime.InvokeAsync<List<Member>>("fetchMembers");

    }

    private void Authenticate()
    {
        if (Members.FindIndex(member => member.Name == PsnId) > 0)
        {
            // Set logged in to true, localStorage
            NavigationManager.NavigateTo("/vote");

            JSRuntime.InvokeVoidAsync("setLocalStorageItem", "member", PsnId);

            ErrorMessage = "";
        }
        else
        {
            ErrorMessage = "Invalid credentials";
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
