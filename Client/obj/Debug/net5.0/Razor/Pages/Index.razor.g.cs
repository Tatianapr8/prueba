#pragma checksum "C:\ProysCicloIII\PracticaSept20\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fa8e6befdbe80b23ffea53ad5118905ec500e75"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorProyII.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProysCicloIII\PracticaSept20\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\PracticaSept20\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProysCicloIII\PracticaSept20\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProysCicloIII\PracticaSept20\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProysCicloIII\PracticaSept20\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProysCicloIII\PracticaSept20\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProysCicloIII\PracticaSept20\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProysCicloIII\PracticaSept20\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProysCicloIII\PracticaSept20\Client\_Imports.razor"
using blazorProyII.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ProysCicloIII\PracticaSept20\Client\_Imports.razor"
using blazorProyII.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\ProysCicloIII\PracticaSept20\Client\_Imports.razor"
using PracticaSept20.Shared.Entity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-deck mb-3");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "<img class=\"card-img-top\" src=\"/Images/imagen1.jpeg\" alt=\"Card image cap\" height=\"250\">\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-body");
            __builder.OpenElement(9, "h5");
            __builder.AddAttribute(10, "class", "card-title");
            __builder.OpenElement(11, "em");
            __builder.AddContent(12, 
#nullable restore
#line 10 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Index.razor"
                                            title_card

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "small");
            __builder.AddAttribute(15, "class", "text-muted");
            __builder.AddContent(16, 
#nullable restore
#line 11 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Index.razor"
                                           content_card

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "footer");
            __builder.AddAttribute(19, "class", "blockquote-footer");
            __builder.OpenElement(20, "small");
            __builder.AddContent(21, 
#nullable restore
#line 14 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Index.razor"
                        author_card

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "card ");
            __builder.AddMarkupContent(25, "<img class=\"card-img-top\" src=\"/Images/imagen2.jpeg\" alt=\"Card image cap\" height=\"250\">\r\n            ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "card-body");
            __builder.OpenElement(28, "h5");
            __builder.AddAttribute(29, "class", "card-title");
            __builder.OpenElement(30, "em");
            __builder.AddContent(31, 
#nullable restore
#line 22 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Index.razor"
                                            title_card

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "small");
            __builder.AddAttribute(34, "class", "text-muted");
            __builder.AddContent(35, 
#nullable restore
#line 23 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Index.razor"
                                           content_card

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "footer");
            __builder.AddAttribute(38, "class", "blockquote-footer");
            __builder.OpenElement(39, "small");
            __builder.AddContent(40, 
#nullable restore
#line 26 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Index.razor"
                        author_card

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "card ");
            __builder.AddMarkupContent(44, "<img class=\"card-img-top\" src=\"/Images/imagen3.jpeg\" alt=\"Card image cap\" height=\"250\">\r\n            ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "card-body");
            __builder.OpenElement(47, "h5");
            __builder.AddAttribute(48, "class", "card-title");
            __builder.OpenElement(49, "em");
            __builder.AddContent(50, 
#nullable restore
#line 34 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Index.razor"
                                            title_card

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenElement(52, "small");
            __builder.AddAttribute(53, "class", "text-muted");
            __builder.AddContent(54, 
#nullable restore
#line 35 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Index.razor"
                                           content_card

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.OpenElement(56, "footer");
            __builder.AddAttribute(57, "class", "blockquote-footer");
            __builder.OpenElement(58, "small");
            __builder.AddContent(59, 
#nullable restore
#line 38 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Index.razor"
                        author_card

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\r\n    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "card-deck mb-3");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "card");
            __builder.AddMarkupContent(65, "<img class=\"card-img-top\" src=\"/Images/imagen4.jpeg\" alt=\"Card image cap\" height=\"250\">\r\n            ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "card-body");
            __builder.OpenElement(68, "h5");
            __builder.AddAttribute(69, "class", "card-title");
            __builder.OpenElement(70, "em");
            __builder.AddContent(71, 
#nullable restore
#line 50 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Index.razor"
                                            title_card

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.OpenElement(73, "small");
            __builder.AddAttribute(74, "class", "text-muted");
            __builder.AddContent(75, 
#nullable restore
#line 51 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Index.razor"
                                           content_card

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n            ");
            __builder.OpenElement(77, "footer");
            __builder.AddAttribute(78, "class", "blockquote-footer");
            __builder.OpenElement(79, "small");
            __builder.AddContent(80, 
#nullable restore
#line 54 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Index.razor"
                        author_card

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n\r\n        ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "card ");
            __builder.AddMarkupContent(84, "<img class=\"card-img-top\" src=\"/Images/imagen5.jpeg\" alt=\"Card image cap\" height=\"250\">\r\n            ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "card-body");
            __builder.OpenElement(87, "h5");
            __builder.AddAttribute(88, "class", "card-title");
            __builder.OpenElement(89, "em");
            __builder.AddContent(90, 
#nullable restore
#line 62 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Index.razor"
                                            title_card

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                ");
            __builder.OpenElement(92, "small");
            __builder.AddAttribute(93, "class", "text-muted");
            __builder.AddContent(94, 
#nullable restore
#line 63 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Index.razor"
                                           content_card

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.OpenElement(96, "footer");
            __builder.AddAttribute(97, "class", "blockquote-footer");
            __builder.OpenElement(98, "small");
            __builder.AddContent(99, 
#nullable restore
#line 66 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Index.razor"
                        author_card

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n\r\n        ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "card ");
            __builder.AddMarkupContent(103, "<img class=\"card-img-top\" src=\"/Images/imagen6.jpeg\" alt=\"Card image cap\" height=\"250\">\r\n            ");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "card-body");
            __builder.OpenElement(106, "h5");
            __builder.AddAttribute(107, "class", "card-title");
            __builder.OpenElement(108, "em");
            __builder.AddContent(109, 
#nullable restore
#line 74 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Index.razor"
                                            title_card

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.OpenElement(111, "small");
            __builder.AddAttribute(112, "class", "text-muted");
            __builder.AddContent(113, 
#nullable restore
#line 75 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Index.razor"
                                           content_card

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n            ");
            __builder.OpenElement(115, "footer");
            __builder.AddAttribute(116, "class", "blockquote-footer");
            __builder.OpenElement(117, "small");
            __builder.AddContent(118, 
#nullable restore
#line 78 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Index.razor"
                        author_card

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n\r\n");
            __builder.AddMarkupContent(120, @"<div><nav aria-label=""Page navigation example""><ul class=""pagination justify-content-center""><li class=""page-item""><a class=""page-link"" href=""#"" aria-label=""Previous""><span aria-hidden=""true"">&laquo;</span>
                    <span class=""sr-only"">Previous</span></a></li>
            <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>

            <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
            <li class=""page-item""><a class=""page-link"" href=""#"" aria-label=""Next""><span aria-hidden=""true"">&raquo;</span>
                    <span class=""sr-only"">Next</span></a></li></ul></nav></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 108 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Index.razor"
                                                                      
    public string title_card = "Nombre pez";
    public string content_card = "Descripci??n de la especie";
    public string author_card = "Tatiana P.";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
