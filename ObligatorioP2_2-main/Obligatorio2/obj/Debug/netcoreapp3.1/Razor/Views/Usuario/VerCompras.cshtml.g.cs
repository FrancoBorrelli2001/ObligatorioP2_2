#pragma checksum "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\VerCompras.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75a151ce24035a3b2f4681031900f1df6ce6705d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_VerCompras), @"mvc.1.0.view", @"/Views/Usuario/VerCompras.cshtml")]
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
#line 1 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\_ViewImports.cshtml"
using Obligatorio2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\_ViewImports.cshtml"
using Obligatorio2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\VerCompras.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75a151ce24035a3b2f4681031900f1df6ce6705d", @"/Views/Usuario/VerCompras.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87e36970f455aae1bee373d97230b042ea67aa2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_VerCompras : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Obligatorio2.Compra>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h4>Tus compras</h4>
<br />
<table class=""table"">
    <thead class=""text-center"">
        <tr>
            <th>
                ID Compra
            </th>
            <th>
                Cantidad de Entradas
            </th>
            <th>
                Nombre de la Actividad
            </th>
            <th>
                Fecha y Hora de la Compra
            </th>
            <th>
                Estado
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
#line 31 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\VerCompras.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\VerCompras.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID_compra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\VerCompras.cshtml"
               Write(Html.DisplayFor(modelItem => item.cant_Entradas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\VerCompras.cshtml"
               Write(Html.DisplayFor(modelItem => item.actividad.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\VerCompras.cshtml"
               Write(Html.DisplayFor(modelItem => item.fecha_hora_compra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\VerCompras.cshtml"
               Write(Html.DisplayFor(modelItem => item.estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\VerCompras.cshtml"
               Write(Html.DisplayFor(modelItem => item.Precio_Final));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\VerCompras.cshtml"
               Write(Html.ActionLink("Cancelar Compra", "CancelarCompra", new { id = item.ID_compra }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 56 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\VerCompras.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Obligatorio2.Compra>> Html { get; private set; }
    }
}
#pragma warning restore 1591
