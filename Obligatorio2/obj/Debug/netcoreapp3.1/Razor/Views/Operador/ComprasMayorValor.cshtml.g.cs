#pragma checksum "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\ComprasMayorValor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5ff11040b44c1118c3c7bc6e2edfe0b420f3859"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Operador_ComprasMayorValor), @"mvc.1.0.view", @"/Views/Operador/ComprasMayorValor.cshtml")]
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
#line 1 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\_ViewImports.cshtml"
using Obligatorio2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\_ViewImports.cshtml"
using Obligatorio2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ff11040b44c1118c3c7bc6e2edfe0b420f3859", @"/Views/Operador/ComprasMayorValor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87e36970f455aae1bee373d97230b042ea67aa2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Operador_ComprasMayorValor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Obligatorio2.Compra>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\ComprasMayorValor.cshtml"
  
    ViewData["Title"] = "ComprasMayorValor";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>La/Las compras de mayor valor es></h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\ComprasMayorValor.cshtml"
           Write(Html.DisplayNameFor(model => model.ID_compra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\ComprasMayorValor.cshtml"
           Write(Html.DisplayNameFor(model => model.cant_Entradas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\ComprasMayorValor.cshtml"
           Write(Html.DisplayNameFor(model => model.fecha_hora_compra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\ComprasMayorValor.cshtml"
           Write(Html.DisplayNameFor(model => model.estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\ComprasMayorValor.cshtml"
           Write(Html.DisplayNameFor(model => model.precio_final));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\ComprasMayorValor.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\ComprasMayorValor.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID_compra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\ComprasMayorValor.cshtml"
           Write(Html.DisplayFor(modelItem => item.cant_Entradas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\ComprasMayorValor.cshtml"
           Write(Html.DisplayFor(modelItem => item.fecha_hora_compra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\ComprasMayorValor.cshtml"
           Write(Html.DisplayFor(modelItem => item.estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\ComprasMayorValor.cshtml"
           Write(Html.DisplayFor(modelItem => item.precio_final));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        \r\n        </tr>\r\n");
#nullable restore
#line 51 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\ComprasMayorValor.cshtml"
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