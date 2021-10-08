#pragma checksum "/Users/lennartsargezian/RiderProjects/ToDo/Todo/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b27c07d7e152440932e1466f861aea2f623e70d"
// <auto-generated/>
#pragma warning disable 1591
namespace ToDo.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/lennartsargezian/RiderProjects/ToDo/Todo/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lennartsargezian/RiderProjects/ToDo/Todo/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/lennartsargezian/RiderProjects/ToDo/Todo/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/lennartsargezian/RiderProjects/ToDo/Todo/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/lennartsargezian/RiderProjects/ToDo/Todo/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/lennartsargezian/RiderProjects/ToDo/Todo/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/lennartsargezian/RiderProjects/ToDo/Todo/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/lennartsargezian/RiderProjects/ToDo/Todo/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/lennartsargezian/RiderProjects/ToDo/Todo/_Imports.razor"
using ToDo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/lennartsargezian/RiderProjects/ToDo/Todo/_Imports.razor"
using ToDo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/lennartsargezian/RiderProjects/ToDo/Todo/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/lennartsargezian/RiderProjects/ToDo/Todo/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/lennartsargezian/RiderProjects/ToDo/Todo/Shared/NavMenu.razor"
using ToDo.Authentication;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(0);
            __builder.AddAttribute(1, "Style", "height: 100px");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenMenu>(3);
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(5);
                    __builder3.AddAttribute(6, "Text", "Home");
                    __builder3.AddAttribute(7, "Icon", "home");
                    __builder3.AddAttribute(8, "Path", "AdultList");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(9, "\n\n        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(10);
                    __builder3.AddAttribute(11, "Policy", "MustBeAdmin");
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenMenuItem>(13);
                        __builder4.AddAttribute(14, "Text", "Adult");
                        __builder4.AddAttribute(15, "Icon", "accessibility");
                        __builder4.AddAttribute(16, "Path", "AddAdults");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(17, "\n        \n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(18);
                    __builder3.AddAttribute(19, "Text", "Diagram");
                    __builder3.AddAttribute(20, "Icon", "assessment");
                    __builder3.AddAttribute(21, "Path", "Diagram");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\n        \n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(23);
                    __builder3.AddAttribute(24, "Text", "");
                    __builder3.AddAttribute(25, "Icon", "input");
                    __builder3.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(27, "a");
                        __builder4.AddAttribute(28, "href", "");
                        __builder4.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "/Users/lennartsargezian/RiderProjects/ToDo/Todo/Shared/NavMenu.razor"
                                         PerformLogout

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "b-0q1luosqk3");
                        __builder4.AddMarkupContent(31, "\n                        Log out\n                    ");
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "/Users/lennartsargezian/RiderProjects/ToDo/Todo/Shared/NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
    

    public async Task PerformLogout() {
    
        try {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/");
        } catch (Exception e) { }
    }

    
    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
