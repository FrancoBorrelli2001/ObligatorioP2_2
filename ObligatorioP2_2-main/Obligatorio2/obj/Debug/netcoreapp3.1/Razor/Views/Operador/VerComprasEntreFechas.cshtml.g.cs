#pragma checksum "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerComprasEntreFechas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3e86161ecd932ac0c2267571e55d3bac8bcefde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Operador_VerComprasEntreFechas), @"mvc.1.0.view", @"/Views/Operador/VerComprasEntreFechas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3e86161ecd932ac0c2267571e55d3bac8bcefde", @"/Views/Operador/VerComprasEntreFechas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87e36970f455aae1bee373d97230b042ea67aa2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Operador_VerComprasEntreFechas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h4>Ver compras realizadas entre dos fechas</h4>\r\n<hr />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3e86161ecd932ac0c2267571e55d3bac8bcefde3846", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <label class=""control-label"">Fecha de inicio</label>
                <input type=""date"" name=""fecha1"" class=""form-control"" />
                <span class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"">Fecha final</label>
                <input type=""date"" name=""fecha2"" class=""form-control"" />
                <span class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Mostrar"" class=""btn btn-primary"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 24 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerComprasEntreFechas.cshtml"
     if (@ViewBag.LC != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerComprasEntreFechas.cshtml"
         if (ViewBag.LC.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h5>No existen compras en el rango de fechas seleccionado.</h5>\r\n");
#nullable restore
#line 29 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerComprasEntreFechas.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <hr />\r\n            <h4>Lista de Compras</h4>\r\n");
            WriteLiteral(@"            <table class=""table"">
                <thead class=""text-center"">
                    <tr>
                        <th>
                            ID Compra
                        </th>
                        <th>
                            Nombre de la Actividad
                        </th>
                        <th>
                            Cantidad de Entradas
                        </th>
                        <th>
                            Usuario
                        </th>
                        <th>
                            Fecha y Hora de la compra
                        </th>
                        <th>
                            Estado
                        </th>
                        <th>
                            Precio Final
                        </th>

                    </tr>
                </thead>
                <tbody class=""text-center"">
");
#nullable restore
#line 63 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerComprasEntreFechas.cshtml"
                     foreach (var compra in @ViewBag.LC)
                    {
                        var PrecioFinal = compra.CalcularPrecioFinal();

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 68 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerComprasEntreFechas.cshtml"
                           Write(compra.ID_compra);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 71 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerComprasEntreFechas.cshtml"
                           Write(compra.actividad.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 74 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerComprasEntreFechas.cshtml"
                           Write(compra.cant_Entradas);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 77 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerComprasEntreFechas.cshtml"
                           Write(compra.usuario.nombreUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 80 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerComprasEntreFechas.cshtml"
                           Write(compra.fecha_hora_compra);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 83 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerComprasEntreFechas.cshtml"
                           Write(compra.estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 86 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerComprasEntreFechas.cshtml"
                           Write(compra.Precio_Final);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 89 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerComprasEntreFechas.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <br />\r\n            <h5>El precio total de todas las compras es ");
#nullable restore
#line 93 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerComprasEntreFechas.cshtml"
                                                   Write(ViewBag.PrecioTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <hr />\r\n");
#nullable restore
#line 95 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerComprasEntreFechas.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerComprasEntreFechas.cshtml"
         
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
