#pragma checksum "C:\Users\user\source\repos\BlazorSample\BlazorSample\Shared\Tab.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21550bda76c414884c4e6f0ea978ab54cacc5b5c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSample.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\user\source\repos\BlazorSample\BlazorSample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\BlazorSample\BlazorSample\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\BlazorSample\BlazorSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\source\repos\BlazorSample\BlazorSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\source\repos\BlazorSample\BlazorSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\source\repos\BlazorSample\BlazorSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\source\repos\BlazorSample\BlazorSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\source\repos\BlazorSample\BlazorSample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\source\repos\BlazorSample\BlazorSample\_Imports.razor"
using BlazorSample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\user\source\repos\BlazorSample\BlazorSample\_Imports.razor"
using BlazorSample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\user\source\repos\BlazorSample\BlazorSample\Shared\Tab.razor"
using BlazorSample.UIInterfaces;

#line default
#line hidden
#nullable disable
    public partial class Tab : Microsoft.AspNetCore.Components.ComponentBase, ITab
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "li");
            __builder.OpenElement(1, "a");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\user\source\repos\BlazorSample\BlazorSample\Shared\Tab.razor"
                 ActivateTab

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "class", "nav-link" + " " + (
#nullable restore
#line 5 "C:\Users\user\source\repos\BlazorSample\BlazorSample\Shared\Tab.razor"
                                               TitleCssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "role", "button");
            __builder.AddContent(5, 
#nullable restore
#line 6 "C:\Users\user\source\repos\BlazorSample\BlazorSample\Shared\Tab.razor"
         Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\user\source\repos\BlazorSample\BlazorSample\Shared\Tab.razor"
       
    [CascadingParameter]
    public TabSet ContainerTabSet { get; set; }

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    private string TitleCssClass =>
        ContainerTabSet.ActiveTab == this ? "active" : null;

    protected override void OnInitialized()
    {
        ContainerTabSet.AddTab(this);
    }

    private void ActivateTab()
    {
        ContainerTabSet.SetActiveTab(this);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
