#pragma checksum "C:\Users\Admin\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Aeropuertos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "136915563b28e52ff8f807b9de05a64af4d9e3ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoCiclo3.App.Frontend.Pages.Aeropuertos.Pages_Aeropuertos_Details), @"mvc.1.0.razor-page", @"/Pages/Aeropuertos/Details.cshtml")]
namespace ProyectoCiclo3.App.Frontend.Pages.Aeropuertos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\_ViewImports.cshtml"
using ProyectoCiclo3.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"136915563b28e52ff8f807b9de05a64af4d9e3ec", @"/Pages/Aeropuertos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fac2ae24fef211f78e08fb554a390914631813e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Aeropuertos_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Admin\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Aeropuertos\Details.cshtml"
  
    var aeropuertos = Model.Aeropuertos;

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n<ul class=\"list-group list-group-flush\">\r\n  <li class=\"list-group-item\"> <b>id: </b> ");
#nullable restore
#line 8 "C:\Users\Admin\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Aeropuertos\Details.cshtml"
                                      Write(aeropuertos.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"> <b>nombre: </b> ");
#nullable restore
#line 9 "C:\Users\Admin\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Aeropuertos\Details.cshtml"
                                          Write(aeropuertos.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"> <b>ciudad: </b> ");
#nullable restore
#line 10 "C:\Users\Admin\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Aeropuertos\Details.cshtml"
                                          Write(aeropuertos.ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>pais: </b> ");
#nullable restore
#line 11 "C:\Users\Admin\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Aeropuertos\Details.cshtml"
                                       Write(aeropuertos.pais);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>coord_x: </b> ");
#nullable restore
#line 12 "C:\Users\Admin\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Aeropuertos\Details.cshtml"
                                          Write(aeropuertos.coord_x);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>coord_y: </b> ");
#nullable restore
#line 13 "C:\Users\Admin\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Aeropuertos\Details.cshtml"
                                          Write(aeropuertos.coord_y);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\t");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoCiclo3.App.Frontend.Pages.DetailsAeropuertosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.DetailsAeropuertosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.DetailsAeropuertosModel>)PageContext?.ViewData;
        public ProyectoCiclo3.App.Frontend.Pages.DetailsAeropuertosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
