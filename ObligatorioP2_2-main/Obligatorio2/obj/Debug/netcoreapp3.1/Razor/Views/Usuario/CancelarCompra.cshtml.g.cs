#pragma checksum "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\CancelarCompra.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc0021cfab3d8042322bb89d0f73f7342ec6b10a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_CancelarCompra), @"mvc.1.0.view", @"/Views/Usuario/CancelarCompra.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc0021cfab3d8042322bb89d0f73f7342ec6b10a", @"/Views/Usuario/CancelarCompra.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fca5f29dab2bc68850e762640eeac72a08f4ecbc", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_CancelarCompra : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VerCompras", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\CancelarCompra.cshtml"
 if (ViewBag.compra == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>");
#nullable restore
#line 4 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\CancelarCompra.cshtml"
   Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc0021cfab3d8042322bb89d0f73f7342ec6b10a4572", async() => {
                WriteLiteral("Volver");
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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\CancelarCompra.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Datos de la compra a eliminar</h4>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc0021cfab3d8042322bb89d0f73f7342ec6b10a6092", async() => {
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label\">ID Compra</label>\r\n                    <input type=\"text\" name=\"IdCompra\"");
                BeginWriteAttribute("value", " value=\"", 426, "\"", 459, 1);
#nullable restore
#line 16 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\CancelarCompra.cshtml"
WriteAttributeValue("", 434, ViewBag.compra.ID_compra, 434, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly class=""form-control"" />
                    <span class=""text-danger""></span>
                </div>
                <div class=""form-group"">
                    <label class=""control-label"">Nombre de la Actividad</label>
                    <input type=""text"" name=""nombreActividad""");
                BeginWriteAttribute("value", " value=\"", 758, "\"", 798, 1);
#nullable restore
#line 21 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\CancelarCompra.cshtml"
WriteAttributeValue("", 766, ViewBag.compra.actividad.Nombre, 766, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly class=""form-control"" />
                    <span class=""text-danger""></span>
                </div>
                <div class=""form-group"">
                    <label class=""control-label"">Cantidad de entradas</label>
                    <input type=""text"" name=""cantEntradas""");
                BeginWriteAttribute("value", " value=\"", 1092, "\"", 1129, 1);
#nullable restore
#line 26 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\CancelarCompra.cshtml"
WriteAttributeValue("", 1100, ViewBag.compra.cant_Entradas, 1100, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly class=""form-control"" />
                    <span class=""text-danger""></span>
                </div>
                <div class=""form-group"">
                    <label class=""control-label"">Fecha y hora</label>
                    <input type=""text"" name=""fechaHora""");
                BeginWriteAttribute("value", " value=\"", 1412, "\"", 1453, 1);
#nullable restore
#line 31 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\CancelarCompra.cshtml"
WriteAttributeValue("", 1420, ViewBag.compra.fecha_hora_compra, 1420, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly class=""form-control"" />
                    <span class=""text-danger""></span>
                </div>
                <div class=""form-group"">
                    <label class=""control-label"">Precio</label>
                    <input type=""text"" name=""Precio""");
                BeginWriteAttribute("value", " value=\"", 1727, "\"", 1763, 1);
#nullable restore
#line 36 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\CancelarCompra.cshtml"
WriteAttributeValue("", 1735, ViewBag.compra.Precio_Final, 1735, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly class=""form-control"" />
                    <span class=""text-danger""></span>
                </div>
                <hr />
                <div class=""form-group"">
                    <h6>Seguro que desea cancelar la compra?</h6>
                    <input type=""submit"" value=""Si"" class=""btn btn-danger"" /><br /><br />
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc0021cfab3d8042322bb89d0f73f7342ec6b10a11450", async() => {
                WriteLiteral("Volver");
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
            WriteLiteral("\r\n");
#nullable restore
#line 49 "D:\Documentos\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\CancelarCompra.cshtml"
}

#line default
#line hidden
#nullable disable
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
