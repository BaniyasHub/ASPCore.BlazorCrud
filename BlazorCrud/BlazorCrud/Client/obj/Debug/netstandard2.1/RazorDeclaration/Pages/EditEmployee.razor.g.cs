// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCrud.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Home\GitHub\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Home\GitHub\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Home\GitHub\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Home\GitHub\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Home\GitHub\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Home\GitHub\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using BlazorCrud.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Home\GitHub\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using BlazorCrud.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Home\GitHub\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
using BlazorCrud.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editemployee/{empID:int}")]
    public partial class EditEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Home\GitHub\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
       
    [Parameter]
    public int empID { get; set; }

    Employee emp = new Employee();

    protected override async Task OnInitializedAsync()
    {
        emp = await Http.GetJsonAsync<Employee>("/api/Employee/Details/" + empID);
    }

    protected async Task UpdateEmployee()
    {
        await Http.SendJsonAsync(HttpMethod.Put, "api/Employee/Edit", emp);
        urlNavigationManager.NavigateTo("/fetchemployee");
    }

    void Cancel()
    {
        urlNavigationManager.NavigateTo("/fetchemployee");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager urlNavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
