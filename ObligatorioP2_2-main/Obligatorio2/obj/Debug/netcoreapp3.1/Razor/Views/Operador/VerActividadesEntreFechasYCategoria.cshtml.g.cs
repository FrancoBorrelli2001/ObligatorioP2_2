#pragma checksum "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9692b4ec02af5439c3bc8cc21a645a3007fa28ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Operador_VerActividadesEntreFechasYCategoria), @"mvc.1.0.view", @"/Views/Operador/VerActividadesEntreFechasYCategoria.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9692b4ec02af5439c3bc8cc21a645a3007fa28ea", @"/Views/Operador/VerActividadesEntreFechasYCategoria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87e36970f455aae1bee373d97230b042ea67aa2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Operador_VerActividadesEntreFechasYCategoria : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h4>Ver Actividades para una categoría entre fechas</h4>\r\n<hr />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9692b4ec02af5439c3bc8cc21a645a3007fa28ea4056", async() => {
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
                <label class=""control-label"">Categoría</label>
                <select name=""nombreCategoria"">
");
#nullable restore
#line 20 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
                     foreach (var categoria in @ViewBag.Categorias)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9692b4ec02af5439c3bc8cc21a645a3007fa28ea5377", async() => {
#nullable restore
#line 22 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
                           Write(categoria.Nombre);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n                <span class=\"text-danger\"></span>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Mostrar\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
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
#line 34 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
 if (@ViewBag.LA != null)
{
    if (@ViewBag.LA.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5>No existen Actividades asociadas a la categoria ");
#nullable restore
#line 38 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
                                                       Write(ViewBag.Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral(" entre ");
#nullable restore
#line 38 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
                                                                                Write(ViewBag.Fecha1.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" y ");
#nullable restore
#line 38 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
                                                                                                                      Write(ViewBag.Fecha2.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 39 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <hr />\r\n        <h5>Lista de Actividaes asociadas a la categoria ");
#nullable restore
#line 43 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
                                                    Write(ViewBag.Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral(", entre ");
#nullable restore
#line 43 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
                                                                              Write(ViewBag.Fecha1.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" y ");
#nullable restore
#line 43 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
                                                                                                                    Write(ViewBag.Fecha2.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <br />\r\n");
            WriteLiteral(@"        <table class=""table"">
            <thead class=""text-center"">
                <tr>
                    <th>
                        ID Actividad
                    </th>
                    <th>
                        Nombre de la Actividad
                    </th>
                    <th>
                        Categoria
                    </th>
                    <th>
                        Fecha y Hora
                    </th>
                    <th>
                        Lugar
                    </th>
                    <th>
                        Edad Minima
                    </th>
                    <th>
                        Cantidad de Me Gusta
                    </th>
                    <th>
                        Precio Entrada
                    </th>
                </tr>
            </thead>
            <tbody class=""text-center"">
");
#nullable restore
#line 76 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
                 foreach (var act in @ViewBag.LA)
                {
                    var PrecioFinal = act.CalcularPrecioFinal();

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 81 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
                       Write(act.Id_actividad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 84 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
                       Write(act.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 87 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
                       Write(act.Categoria.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 90 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
                       Write(act.Fecha_y_hora);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 93 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
                       Write(act.Lugar.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 96 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
                       Write(act.Edad_minima);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 99 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
                       Write(act.Cantidad_me_gusta);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 102 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
                       Write(PrecioFinal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 105 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 108 "C:\Users\cloti\OneDrive\Documents\GitHub\ObligatorioP2_2\ObligatorioP2_2-main\Obligatorio2\Views\Operador\VerActividadesEntreFechasYCategoria.cshtml"
    }
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
