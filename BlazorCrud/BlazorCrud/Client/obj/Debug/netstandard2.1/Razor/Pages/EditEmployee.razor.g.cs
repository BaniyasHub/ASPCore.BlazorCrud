#pragma checksum "C:\Home\GitHub\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2b9bcc0c04560b0e573f9993d9cdc02081143bc"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h2>Edit Employee</h2>\r\n<hr>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Home\GitHub\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                  emp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Home\GitHub\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                                      UpdateEmployee

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group row");
                __builder2.AddMarkupContent(9, "<label class=\"control-label col-md-12\">Name</label>\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-md-4");
                __builder2.OpenElement(12, "input");
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Home\GitHub\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                                               emp.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.Name = __value, emp.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __Blazor.BlazorCrud.Client.Pages.EditEmployee.TypeInference.CreateValidationMessage_0(__builder2, 17, 18, 
#nullable restore
#line 16 "C:\Home\GitHub\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                                  () => emp.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group row");
                __builder2.AddMarkupContent(22, "<label class=\"control-label col-md-12\">Gender</label>\r\n        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "col-md-4");
                __builder2.OpenElement(25, "select");
                __builder2.AddAttribute(26, "asp-for", "Gender");
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Home\GitHub\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                                                                 emp.Gender

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.Gender = __value, emp.Gender));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(30, "option");
                __builder2.AddAttribute(31, "value", true);
                __builder2.AddContent(32, "-- Select Gender --");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                ");
                __builder2.OpenElement(34, "option");
                __builder2.AddAttribute(35, "value", "Male");
                __builder2.AddContent(36, "Male");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.OpenElement(38, "option");
                __builder2.AddAttribute(39, "value", "Female");
                __builder2.AddContent(40, "Female");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.OpenElement(42, "span");
                __Blazor.BlazorCrud.Client.Pages.EditEmployee.TypeInference.CreateValidationMessage_1(__builder2, 43, 44, 
#nullable restore
#line 27 "C:\Home\GitHub\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                                        () => emp.Gender

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n    ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-group row");
                __builder2.AddMarkupContent(48, "<label class=\"control-label col-md-12\">Department</label>\r\n        ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "col-md-4");
                __builder2.OpenElement(51, "input");
                __builder2.AddAttribute(52, "class", "form-control");
                __builder2.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Home\GitHub\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                                               emp.Department

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.Department = __value, emp.Department));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.OpenElement(56, "span");
                __Blazor.BlazorCrud.Client.Pages.EditEmployee.TypeInference.CreateValidationMessage_2(__builder2, 57, 58, 
#nullable restore
#line 34 "C:\Home\GitHub\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                                        () => emp.Department

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n    ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group row");
                __builder2.AddMarkupContent(62, "<label class=\"control-label col-md-12\">City</label>\r\n        ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "col-md-4");
                __builder2.OpenElement(65, "input");
                __builder2.AddAttribute(66, "class", "form-control");
                __builder2.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Home\GitHub\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                                               emp.City

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.City = __value, emp.City));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n        ");
                __builder2.OpenElement(70, "span");
                __Blazor.BlazorCrud.Client.Pages.EditEmployee.TypeInference.CreateValidationMessage_3(__builder2, 71, 72, 
#nullable restore
#line 41 "C:\Home\GitHub\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                                        () => emp.City

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n    ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "form-group");
                __builder2.AddMarkupContent(76, "<button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n        ");
                __builder2.OpenElement(77, "button");
                __builder2.AddAttribute(78, "class", "btn btn-light");
                __builder2.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Home\GitHub\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\Pages\EditEmployee.razor"
                                                Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(80, "Cancel");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.BlazorCrud.Client.Pages.EditEmployee
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
