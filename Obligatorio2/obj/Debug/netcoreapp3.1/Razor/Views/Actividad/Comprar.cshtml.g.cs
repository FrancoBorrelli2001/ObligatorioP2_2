#pragma checksum "D:\Documentos\GitHub\ObligatorioP2_2\Obligatorio2\Views\Actividad\Comprar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ae45033f30a069db69eab7a9e09b010350c6d36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actividad_Comprar), @"mvc.1.0.view", @"/Views/Actividad/Comprar.cshtml")]
namespace AspNetCore
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
#line 1 "D:\Documentos\GitHub\ObligatorioP2_2\Obligatorio2\Views\_ViewImports.cshtml"
using Obligatorio2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documentos\GitHub\ObligatorioP2_2\Obligatorio2\Views\_ViewImports.cshtml"
using Obligatorio2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ae45033f30a069db69eab7a9e09b010350c6d36", @"/Views/Actividad/Comprar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87e36970f455aae1bee373d97230b042ea67aa2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Actividad_Comprar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<h1>Comprar entrada para la actividad</h1>\r\n<h2>Datos de la actividad a Comprar</h2>\r\n<label>Nombre</label><br />\r\n<input type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 148, "\"", 190, 1);
#nullable restore
#line 7 "D:\Documentos\GitHub\ObligatorioP2_2\Obligatorio2\Views\Actividad\Comprar.cshtml"
WriteAttributeValue("", 156, ViewBag.ActividadModificar.Nombre, 156, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/><br />\r\n<label>Categoria</label><br />\r\n<input type=\"text\"  readonly");
            BeginWriteAttribute("value", " value=\"", 261, "\"", 313, 1);
#nullable restore
#line 9 "D:\Documentos\GitHub\ObligatorioP2_2\Obligatorio2\Views\Actividad\Comprar.cshtml"
WriteAttributeValue("", 269, ViewBag.ActividadModificar.Categoria.Nombre, 269, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/><br />\r\n<label>Fecha</label><br />\r\n<input type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 379, "\"", 427, 1);
#nullable restore
#line 11 "D:\Documentos\GitHub\ObligatorioP2_2\Obligatorio2\Views\Actividad\Comprar.cshtml"
WriteAttributeValue("", 387, ViewBag.ActividadModificar.Fecha_y_hora, 387, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/><br />\r\n<label>Lugar</label><br /> \r\n<input type=\"text\" readonly");
            BeginWriteAttribute("value", "  value=\"", 494, "\"", 543, 1);
#nullable restore
#line 13 "D:\Documentos\GitHub\ObligatorioP2_2\Obligatorio2\Views\Actividad\Comprar.cshtml"
WriteAttributeValue("", 503, ViewBag.ActividadModificar.Lugar.Nombre, 503, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/><br />\r\n<label>Edad Mínima</label><br />\r\n<input type=\"text\" readonly");
            BeginWriteAttribute("value", "  value=\"", 615, "\"", 663, 1);
#nullable restore
#line 15 "D:\Documentos\GitHub\ObligatorioP2_2\Obligatorio2\Views\Actividad\Comprar.cshtml"
WriteAttributeValue("", 624, ViewBag.ActividadModificar.Edad_minima, 624, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /><br />\r\n<label>Cantidad de MG</label><br />\r\n<input type=\"text\" readonly");
            BeginWriteAttribute("value", "  value=\"", 739, "\"", 793, 1);
#nullable restore
#line 17 "D:\Documentos\GitHub\ObligatorioP2_2\Obligatorio2\Views\Actividad\Comprar.cshtml"
WriteAttributeValue("", 748, ViewBag.ActividadModificar.Cantidad_me_gusta, 748, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/><br /> <hr />\r\n<label>Precio Final</label><br />\r\n<input type=\"text\" readonly");
            BeginWriteAttribute("value", "  value=\"", 873, "\"", 921, 1);
#nullable restore
#line 19 "D:\Documentos\GitHub\ObligatorioP2_2\Obligatorio2\Views\Actividad\Comprar.cshtml"
WriteAttributeValue("", 882, ViewBag.ActividadModificar.PrecioFinal, 882, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/><br /> <hr />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
