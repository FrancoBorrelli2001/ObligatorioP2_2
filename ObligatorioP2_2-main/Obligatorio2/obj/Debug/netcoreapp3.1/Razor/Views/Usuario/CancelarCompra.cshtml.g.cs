#pragma checksum "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\CancelarCompra.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40a1f1ffea420d861c9fb716cb6e9dfe2c48f8e4"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a1f1ffea420d861c9fb716cb6e9dfe2c48f8e4", @"/Views/Usuario/CancelarCompra.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87e36970f455aae1bee373d97230b042ea67aa2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_CancelarCompra : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VerComprasACancelar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- #region codigo anterior -->\r\n");
            WriteLiteral("<!-- #endregion Page Header -->\r\n\r\n<h4>Datos de la compra a eliminar</h4>\r\n<hr />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40a1f1ffea420d861c9fb716cb6e9dfe2c48f8e44348", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">ID Compra</label>\r\n                <input type=\"text\" name=\"IdCompra\"");
                BeginWriteAttribute("value", " value=\"", 1320, "\"", 1353, 1);
#nullable restore
#line 30 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\CancelarCompra.cshtml"
WriteAttributeValue("", 1328, ViewBag.compra.ID_compra, 1328, 25, false);

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
                BeginWriteAttribute("value", " value=\"", 1632, "\"", 1672, 1);
#nullable restore
#line 35 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\CancelarCompra.cshtml"
WriteAttributeValue("", 1640, ViewBag.compra.actividad.Nombre, 1640, 32, false);

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
                BeginWriteAttribute("value", " value=\"", 1946, "\"", 1983, 1);
#nullable restore
#line 40 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\CancelarCompra.cshtml"
WriteAttributeValue("", 1954, ViewBag.compra.cant_Entradas, 1954, 29, false);

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
                BeginWriteAttribute("value", " value=\"", 2246, "\"", 2287, 1);
#nullable restore
#line 45 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\CancelarCompra.cshtml"
WriteAttributeValue("", 2254, ViewBag.compra.fecha_hora_compra, 2254, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly class=\"form-control\" />\r\n                <span class=\"text-danger\"></span>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">Precio</label>\r\n                <input type=\"text\" name=\"Precio\"");
                BeginWriteAttribute("value", " value=\"", 2541, "\"", 2577, 1);
#nullable restore
#line 50 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Usuario\CancelarCompra.cshtml"
WriteAttributeValue("", 2549, ViewBag.compra.Precio_Final, 2549, 28, false);

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
                <input type=""submit"" value=""Si"" class=""btn btn-primary"" /><br /><br />
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40a1f1ffea420d861c9fb716cb6e9dfe2c48f8e48448", async() => {
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
                WriteLiteral("\r\n            </div>\r\n        ");
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
            WriteLiteral("\r\n    </div>\r\n</div>");
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
