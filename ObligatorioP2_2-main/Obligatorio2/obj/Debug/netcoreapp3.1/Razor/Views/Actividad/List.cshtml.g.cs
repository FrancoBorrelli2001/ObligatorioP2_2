#pragma checksum "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Actividad\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8f290356b53460f815a863c88f8c4a723229bde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actividad_List), @"mvc.1.0.view", @"/Views/Actividad/List.cshtml")]
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
#line 1 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\_ViewImports.cshtml"
using Obligatorio2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\_ViewImports.cshtml"
using Obligatorio2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Actividad\List.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8f290356b53460f815a863c88f8c4a723229bde", @"/Views/Actividad/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fca5f29dab2bc68850e762640eeac72a08f4ecbc", @"/Views/_ViewImports.cshtml")]
    public class Views_Actividad_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Obligatorio2.Actividad>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Actividad\List.cshtml"
   ViewData["Title"] = "List"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h4>Lista de Actividades</h4>
<br />

<table class=""table"">
    <thead>
        <tr class=""text-center"">
            <th>
                ID
            </th>
            <th>
                Nombre
            </th>
            <th>
                Fecha y Hora
            </th>
            <th>
                Edad Minima
            </th>
            <th>
                Me Gusta
            </th>
            <th>
                Precio Final
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody class=""text-center"">
");
#nullable restore
#line 33 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Actividad\List.cshtml"
         foreach (var item in Model)
        {

            var PrecioFinal = item.CalcularPrecioFinal();

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Actividad\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id_actividad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Actividad\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Actividad\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Fecha_y_hora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Actividad\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Edad_minima));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Actividad\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cantidad_me_gusta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Actividad\List.cshtml"
               Write(PrecioFinal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n");
#nullable restore
#line 57 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Actividad\List.cshtml"
                 if (@Context.Session.GetString("RolLogueado") == "Cliente")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 60 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Actividad\List.cshtml"
                   Write(Html.ActionLink("Comprar", "Comprar", new { id = item.Id_actividad }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 61 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Actividad\List.cshtml"
                   Write(Html.ActionLink("Me gusta!", "MeGusta", new { id = item.Id_actividad }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 63 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Actividad\List.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td></td>\r\n");
#nullable restore
#line 67 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Actividad\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 69 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Actividad\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Obligatorio2.Actividad>> Html { get; private set; }
    }
}
#pragma warning restore 1591
