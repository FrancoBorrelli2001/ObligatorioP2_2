#pragma checksum "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\VerClientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55d3197b4907ca712e3be01a022e798626fe51d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Operador_VerClientes), @"mvc.1.0.view", @"/Views/Operador/VerClientes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55d3197b4907ca712e3be01a022e798626fe51d5", @"/Views/Operador/VerClientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87e36970f455aae1bee373d97230b042ea67aa2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Operador_VerClientes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Obligatorio2.Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\VerClientes.cshtml"
  
    ViewData["Title"] = "VerClientes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>VerClientes</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\VerClientes.cshtml"
           Write(Html.DisplayNameFor(model => model.ID_usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\VerClientes.cshtml"
           Write(Html.DisplayNameFor(model => model.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\VerClientes.cshtml"
           Write(Html.DisplayNameFor(model => model.apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\VerClientes.cshtml"
           Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\VerClientes.cshtml"
           Write(Html.DisplayNameFor(model => model.fecha_nacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\VerClientes.cshtml"
           Write(Html.DisplayNameFor(model => model.nombreUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\VerClientes.cshtml"
           Write(Html.DisplayNameFor(model => model.password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\VerClientes.cshtml"
           Write(Html.DisplayNameFor(model => model.rol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 41 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\VerClientes.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\VerClientes.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID_usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\VerClientes.cshtml"
           Write(Html.DisplayFor(modelItem => item.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\VerClientes.cshtml"
           Write(Html.DisplayFor(modelItem => item.apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\VerClientes.cshtml"
           Write(Html.DisplayFor(modelItem => item.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\VerClientes.cshtml"
           Write(Html.DisplayFor(modelItem => item.fecha_nacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\VerClientes.cshtml"
           Write(Html.DisplayFor(modelItem => item.nombreUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\VerClientes.cshtml"
           Write(Html.DisplayFor(modelItem => item.password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\VerClientes.cshtml"
           Write(Html.DisplayFor(modelItem => item.rol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n           \r\n        </tr>\r\n");
#nullable restore
#line 69 "D:\Repo\ObligatorioP2_2\Obligatorio2\Views\Operador\VerClientes.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Obligatorio2.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
