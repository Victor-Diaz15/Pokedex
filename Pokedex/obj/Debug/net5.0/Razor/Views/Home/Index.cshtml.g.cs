#pragma checksum "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Pokedex\Pokedex\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f263e3dd5a29b9993e1e355aba113610bdbcab3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Pokedex\Pokedex\Views\_ViewImports.cshtml"
using Pokedex;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Pokedex\Pokedex\Views\_ViewImports.cshtml"
using Pokedex.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Pokedex\Pokedex\Views\Home\Index.cshtml"
using Application.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f263e3dd5a29b9993e1e355aba113610bdbcab3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5da491ecae30895087782c13bde70b295c8ac28", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Application.ViewModels.PokemonViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex mx-2 col justify-content-end w-100 gap-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "null", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Pokedex\Pokedex\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div id=\"home\" class=\"col-10 mx-auto d-flex align-items-center gap-5 text-center my-3\">\r\n        <div class=\"mx-2\">\r\n            <h1 class=\"display-4\">Pokedex</h1>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f263e3dd5a29b9993e1e355aba113610bdbcab35745", async() => {
                WriteLiteral("\r\n            <div>\r\n                <input class=\"form-control form-control\" type=\"text\" placeholder=\"Buscar Por Nombre\" name=\"Name\">\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-outline-primary\">Buscar</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f263e3dd5a29b9993e1e355aba113610bdbcab37936", async() => {
                WriteLiteral("\r\n            <div>\r\n                <select style=\"cursor: pointer;\" class=\"form-select\" name=\"IdRegion\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f263e3dd5a29b9993e1e355aba113610bdbcab38330", async() => {
                    WriteLiteral("Filtrar por Regiones");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Pokedex\Pokedex\Views\Home\Index.cshtml"
                     foreach (RegionViewModel item in ViewBag.Regions)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f263e3dd5a29b9993e1e355aba113610bdbcab39914", async() => {
#nullable restore
#line 24 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Pokedex\Pokedex\Views\Home\Index.cshtml"
                                                  Write(item.NameRegion);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Pokedex\Pokedex\Views\Home\Index.cshtml"
                           WriteLiteral(item.IdRegion);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Pokedex\Pokedex\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-outline-primary\">Buscar</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"container-fluid\">\r\n    <div class=\"d-flex justify-content-around  flex-wrap\">\r\n");
#nullable restore
#line 34 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Pokedex\Pokedex\Views\Home\Index.cshtml"
         if (Model == null || Model.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2 class=\"text-center fw-bold\">No hay pokemones</h2>\r\n");
#nullable restore
#line 37 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Pokedex\Pokedex\Views\Home\Index.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Pokedex\Pokedex\Views\Home\Index.cshtml"
             foreach (Application.ViewModels.PokemonViewModel item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card col-4 m-3\" style=\"width: 18rem;\">\r\n                    <img style=\"height: 260px\"");
            BeginWriteAttribute("src", " src=", 1851, "", 1870, 1);
#nullable restore
#line 43 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Pokedex\Pokedex\Views\Home\Index.cshtml"
WriteAttributeValue("", 1856, item.ImageUrl, 1856, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"bd-placeholder-img card-img-top\" alt=\"...\">\r\n                    <div class=\"card-body\">\r\n                        <h3 class=\"card-text text-center pb-3\">");
#nullable restore
#line 45 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Pokedex\Pokedex\Views\Home\Index.cshtml"
                                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <div class=\"card-footer\">\r\n                            <div class=\"d-flex flex-column\">\r\n                                <h5>Region: <span class=\"fw-light\">");
#nullable restore
#line 48 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Pokedex\Pokedex\Views\Home\Index.cshtml"
                                                              Write(item.Region);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n                                <h6>Tipo Primario: <span class=\"fw-light\">");
#nullable restore
#line 49 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Pokedex\Pokedex\Views\Home\Index.cshtml"
                                                                     Write(item.PrimaryType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\r\n                                <h6>Tipo Secundario: <span class=\"fw-light\">");
#nullable restore
#line 50 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Pokedex\Pokedex\Views\Home\Index.cshtml"
                                                                       Write(item.SecondaryType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 55 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Pokedex\Pokedex\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Pokedex\Pokedex\Views\Home\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Application.ViewModels.PokemonViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
