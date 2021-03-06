#pragma checksum "C:\ProysCicloIII\PracticaSept20\Client\Pages\Asynctask.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7c07c1d7f918e4d04e32ebd70aa538120d83083"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/asynctask")]
    public partial class Asynctask : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
#nullable restore
#line 3 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Asynctask.razor"
     if (Fishes == null){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<img src=\"/Images/loading.gif\" class=\"rounded mx-auto d=block\" width=\"150px\" height=\"150px\" alt=\"Responsive image\">\r\n            ");
            __builder.AddMarkupContent(3, "<label class=\"text muted\">Cargando...</label>");
#nullable restore
#line 6 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Asynctask.razor"
    }
    else{
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Asynctask.razor"
         for (int i = 0; i < Fishes.Count; i++){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "list-group mb-3");
            __builder.OpenElement(6, "a");
            __builder.AddAttribute(7, "href", "#");
            __builder.AddAttribute(8, "class", "list-group-item list-group-item-action flex-column align-items-start");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-3");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 13 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Asynctask.razor"
                                       Fishes[i].FishImage

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "class", "img-thumbnail");
            __builder.AddAttribute(16, "alt");
            __builder.AddAttribute(17, "width", "200px");
            __builder.AddAttribute(18, "height", "200px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-md-9");
            __builder.OpenElement(22, "h4");
            __builder.AddAttribute(23, "class", "text-left");
            __builder.AddMarkupContent(24, "\r\n                                Especie de pez: \r\n                                ");
            __builder.OpenElement(25, "small");
            __builder.AddAttribute(26, "class", "text-muted");
            __builder.AddContent(27, 
#nullable restore
#line 18 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Asynctask.razor"
                                                           Fishes[i].FishSpecie

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                            Descripci??n:\r\n                            ");
            __builder.OpenElement(29, "p");
            __builder.AddAttribute(30, "class", "mb-0 text-left");
            __builder.AddContent(31, 
#nullable restore
#line 21 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Asynctask.razor"
                                                       Fishes[i].DescriptionSpecie

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                            Tipo de agua en la que habita:\r\n                            ");
            __builder.OpenElement(33, "small");
            __builder.AddAttribute(34, "class", "text-muted");
            __builder.AddContent(35, 
#nullable restore
#line 23 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Asynctask.razor"
                                                       Fishes[i].TypeOfWater

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "footer");
            __builder.AddAttribute(38, "class", "blockquote-footer text-left");
            __builder.AddMarkupContent(39, "Fecha de la publicaci??n ");
            __builder.OpenElement(40, "cite");
            __builder.AddAttribute(41, "title", "Source Title");
            __builder.AddContent(42, 
#nullable restore
#line 25 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Asynctask.razor"
                                                  Fishes[i].PublicationDate.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Asynctask.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Asynctask.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Asynctask.razor"
      
    public List<Fish> Fishes;
    private List<Fish> GetFishes()
    {
        return new List<Fish>(){
            new Fish()
            {
            FishSpecie = "Beta 1", DescriptionSpecie = "Descripci??n del tipo de pez Beta 1",TypeOfWater = "Dulce",FishImage = "/Images/imagen1.jpeg", PublicationDate = new DateTime(2021, 09, 20)},
            new Fish()
            {
            FishSpecie = "Beta 2", DescriptionSpecie = "Descripci??n del tipo de pez Beta 2",TypeOfWater = "Salada",FishImage
            = "/Images/imagen2.jpeg", PublicationDate = new DateTime(2021, 08, 20)},
            new Fish()
            {
            FishSpecie = "Beta 3", DescriptionSpecie = "Descripci??n del tipo de pez Beta 3",TypeOfWater = "Dulce",FishImage
            = "/Images/imagen3.jpeg", PublicationDate = new DateTime(2021, 07, 20)},
            new Fish()
            {
            FishSpecie = "Beta 4", DescriptionSpecie = "Descripci??n del tipo de pez Beta 4",TypeOfWater = "Salada",FishImage
            = "/Images/imagen4.jpeg", PublicationDate = new DateTime(2021, 09, 20)},
            new Fish()
            {
            FishSpecie = "Beta 5", DescriptionSpecie = "Descripci??n del tipo de pez Beta 5",TypeOfWater = "Dulce",FishImage
            = "/Images/imagen5.jpeg", PublicationDate = new DateTime(2021, 08, 20)},
            new Fish()
            {
            FishSpecie = "Beta 6", DescriptionSpecie = "Descripci??n del tipo de pez Beta 6",TypeOfWater = "Salada",FishImage
            = "/Images/imagen6.jpeg", PublicationDate = new DateTime(2021, 07, 20)}
            };
    }

    protected override async Task OnInitializedAsync()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Asynctask.razor"
                                                                         
        await Task.Delay(3000);
        Fishes = GetFishes();

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
