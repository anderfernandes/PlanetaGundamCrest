#pragma checksum "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Vote.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2dbc19f7ca846848ef9d087348c56e48e1f4d28"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/vote")]
    public partial class Vote : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row d-flex align-items-center m-5");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-12");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "h5");
            __builder.AddContent(7, "Welcome, ");
            __builder.OpenElement(8, "em");
            __builder.AddContent(9, 
#nullable restore
#line 8 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Vote.razor"
                          Member

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(10, "! Please select the crest you like the most:");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 10 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Vote.razor"
     foreach (Crest crest in Crests)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-sm-4 col-xs-6");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card mb-4 shadow-sm");
            __builder.AddAttribute(19, "style", "background-color:" + (
#nullable restore
#line 14 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Vote.razor"
                                      Selection == crest.Author ? "gold" : "white"

#line default
#line hidden
#nullable disable
            ) + ";" + " cursor:pointer");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Vote.razor"
                      (() => Selection = crest.Author)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "img");
            __builder.AddAttribute(23, "src", 
#nullable restore
#line 16 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Vote.razor"
                       crest.Src

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "alt", true);
            __builder.AddAttribute(25, "class", "card-img-top");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "card-body");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "h5");
            __builder.AddAttribute(31, "class", "card-title text-center");
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.AddContent(33, 
#nullable restore
#line 19 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Vote.razor"
                      $"@{crest.Author}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "  \r\n");
#nullable restore
#line 24 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Vote.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "col-md-12");
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Vote.razor"
                          RegisterVote

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "class", "btn btn-block btn-lg btn-success");
            __builder.AddAttribute(46, "style", "display:" + (
#nullable restore
#line 26 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Vote.razor"
                                                                                                  String.IsNullOrWhiteSpace(Selection) ? "none" : "block"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(47, "\r\n            Click here to confirm your vote to ");
            __builder.OpenElement(48, "strong");
            __builder.AddContent(49, 
#nullable restore
#line 27 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Vote.razor"
                                                         $"{Selection}'s"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, " design\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Vote.razor"
       

    public List<Crest> Crests { get; set; } = new List<Crest>();

    public string Member { get; set; }

    public string Selection { get; set; }

    public int Count { get; set; } = 0;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        Crests = await JSRuntime.InvokeAsync<List<Crest>>("fetchCrests");

        var member = await JSRuntime.InvokeAsync<string>("getLocalStorageItem", "member");

        if (!String.IsNullOrWhiteSpace(member))
            Member = member;
        else
            NavigationManager.NavigateTo("/login");

    }

    public async Task RegisterVote()
    {
        var crest = Crests.Find(crest => crest.Author == Selection);
        
        await JSRuntime.InvokeVoidAsync("registerVote", Member, crest.Id);

        NavigationManager.NavigateTo("/");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
