#pragma checksum "C:\Users\bvail\Documents\GitHub\HttpClient_IAmTimCorey_2020-July_45min\HttpClient_IAmCorey_2020-July\HttpClient_IAmCorey_2020-July\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71d97dab85cca5c6ce5851fe7fa60535c5a8c794"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HttpClient_IAmCorey_2020_July.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bvail\Documents\GitHub\HttpClient_IAmTimCorey_2020-July_45min\HttpClient_IAmCorey_2020-July\HttpClient_IAmCorey_2020-July\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bvail\Documents\GitHub\HttpClient_IAmTimCorey_2020-July_45min\HttpClient_IAmCorey_2020-July\HttpClient_IAmCorey_2020-July\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bvail\Documents\GitHub\HttpClient_IAmTimCorey_2020-July_45min\HttpClient_IAmCorey_2020-July\HttpClient_IAmCorey_2020-July\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bvail\Documents\GitHub\HttpClient_IAmTimCorey_2020-July_45min\HttpClient_IAmCorey_2020-July\HttpClient_IAmCorey_2020-July\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bvail\Documents\GitHub\HttpClient_IAmTimCorey_2020-July_45min\HttpClient_IAmCorey_2020-July\HttpClient_IAmCorey_2020-July\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bvail\Documents\GitHub\HttpClient_IAmTimCorey_2020-July_45min\HttpClient_IAmCorey_2020-July\HttpClient_IAmCorey_2020-July\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bvail\Documents\GitHub\HttpClient_IAmTimCorey_2020-July_45min\HttpClient_IAmCorey_2020-July\HttpClient_IAmCorey_2020-July\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bvail\Documents\GitHub\HttpClient_IAmTimCorey_2020-July_45min\HttpClient_IAmCorey_2020-July\HttpClient_IAmCorey_2020-July\_Imports.razor"
using HttpClient_IAmCorey_2020_July;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bvail\Documents\GitHub\HttpClient_IAmTimCorey_2020-July_45min\HttpClient_IAmCorey_2020-July\HttpClient_IAmCorey_2020-July\_Imports.razor"
using HttpClient_IAmCorey_2020_July.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bvail\Documents\GitHub\HttpClient_IAmTimCorey_2020-July_45min\HttpClient_IAmCorey_2020-July\HttpClient_IAmCorey_2020-July\_Imports.razor"
using HttpClient_IAmCorey_2020_July.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\bvail\Documents\GitHub\HttpClient_IAmTimCorey_2020-July_45min\HttpClient_IAmCorey_2020-July\HttpClient_IAmCorey_2020-July\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bvail\Documents\GitHub\HttpClient_IAmTimCorey_2020-July_45min\HttpClient_IAmCorey_2020-July\HttpClient_IAmCorey_2020-July\Pages\FetchData.razor"
using HttpClient_IAmCorey_2020_July.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\bvail\Documents\GitHub\HttpClient_IAmTimCorey_2020-July_45min\HttpClient_IAmCorey_2020-July\HttpClient_IAmCorey_2020-July\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
