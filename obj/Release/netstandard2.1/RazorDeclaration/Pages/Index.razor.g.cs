#pragma checksum "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a6fda9d7f18b14f0b14e172e32c18134d4b5f93"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\Anderson\Desktop\PlanetaGundamCrest\Pages\Index.razor"
       

    public List<Crest> Crests { get; set; } = new List<Crest>();
    
    public int TotalVotes { get; set; } = 0;

    protected override async Task OnInitializedAsync()
    {

        await base.OnInitializedAsync();

        Crests = await JSRuntime.InvokeAsync<List<Crest>>("fetchCrests");

        Crests.ForEach(c => TotalVotes += c.Voters.Count);

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
