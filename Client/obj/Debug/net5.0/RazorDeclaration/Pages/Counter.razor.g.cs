// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Counter.razor"
                                                                                   
    private Fish GetFish()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Counter.razor"
                                                                                        
        return new Fish()
        {
            FishSpecie = "Beta 1",
            DescriptionSpecie = "Descripción del tipo de pez Beta 1",
            TypeOfWater = "Dulce",
            FishImage = "/Images/imagen1.jpeg",
            PublicationDate = new DateTime(2021, 09, 20)
        };
    }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\ProysCicloIII\PracticaSept20\Client\Pages\Counter.razor"
                                                                                     
    public Fish BetaFish1
    {
        get { return GetFish(); }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
