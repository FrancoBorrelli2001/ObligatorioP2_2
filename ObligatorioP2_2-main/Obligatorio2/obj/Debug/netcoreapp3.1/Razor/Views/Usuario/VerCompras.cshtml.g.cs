#pragma checksum "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\VerCompras.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "857a523a6e8101672eeb6c76ecd24433734cb1fb"
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
#line 2 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\VerCompras.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"857a523a6e8101672eeb6c76ecd24433734cb1fb", @"/Views/Usuario/VerCompras.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fca5f29dab2bc68850e762640eeac72a08f4ecbc", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_VerCompras : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Obligatorio2.Compra>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VerComprasACancelar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n<h1>Compras del cliente ");
#nullable restore
#line 6 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\VerCompras.cshtml"
                   Write(Context.Session.GetString("NombreLogueado"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<hr />
<table class=""table"">
    <thead>
        <tr>
            <th>
               ID Compra
            </th>
            <th>
                Cantidad de Entradas
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
    <tbody>
");
#nullable restore
#line 31 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\VerCompras.cshtml"
         foreach (var item in Model)
        {
           

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 36 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\VerCompras.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID_compra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 39 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\VerCompras.cshtml"
               Write(Html.DisplayFor(modelItem => item.cant_Entradas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n\n                <td>\n                    ");
#nullable restore
#line 43 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\VerCompras.cshtml"
               Write(Html.DisplayFor(modelItem => item.fecha_hora_compra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 46 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\VerCompras.cshtml"
               Write(Html.DisplayFor(modelItem => item.estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 49 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\VerCompras.cshtml"
               Write(Html.DisplayFor(modelItem => item.Precio_Final));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 52 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\VerCompras.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n\n\n    <hr />\n\n</table>\n<h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "857a523a6e8101672eeb6c76ecd24433734cb1fb6834", async() => {
                WriteLiteral("Cancelar Compras");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\n");
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