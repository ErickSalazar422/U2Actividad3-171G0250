#pragma checksum "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\U2Actividad3-171G0250\Views\Home\cortos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b0930494d6926e277979063b01ff288173a4d77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_cortos), @"mvc.1.0.view", @"/Views/Home/cortos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b0930494d6926e277979063b01ff288173a4d77", @"/Views/Home/cortos.cshtml")]
    public class Views_Home_cortos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<U2Actividad3_171G0250.Models.ViewModels.DatosCortoViewModel>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\U2Actividad3-171G0250\Views\Home\cortos.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\U2Actividad3-171G0250\Views\Home\cortos.cshtml"
     foreach (var Categ in Model   )
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"principalPeliculas\">\r\n\r\n    <div id=\"pelis\">\r\n        <h1>");
#nullable restore
#line 13 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\U2Actividad3-171G0250\Views\Home\cortos.cshtml"
       Write(Categ.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n");
#nullable restore
#line 16 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\U2Actividad3-171G0250\Views\Home\cortos.cshtml"
         foreach (var cat in Categ.Cortometraje)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <a class=\"imgPelicula\"");
            BeginWriteAttribute("href", " href=\"", 373, "\"", 398, 2);
            WriteAttributeValue("", 380, "/Corto/", 380, 7, true);
#nullable restore
#line 19 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\U2Actividad3-171G0250\Views\Home\cortos.cshtml"
WriteAttributeValue("", 387, cat.Nombre, 387, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2b0930494d6926e277979063b01ff288173a4d774262", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 432, "~/images/portadas/", 432, 18, true);
#nullable restore
#line 20 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\U2Actividad3-171G0250\Views\Home\cortos.cshtml"
AddHtmlAttributeValue("", 450, cat.Id, 450, 9, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 459, "_pc.jpg", 459, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </a>\r\n                <div class=\"nombrePelicula\">\r\n                    <p>");
#nullable restore
#line 23 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\U2Actividad3-171G0250\Views\Home\cortos.cshtml"
                  Write(cat.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 26 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\U2Actividad3-171G0250\Views\Home\cortos.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
#nullable restore
#line 29 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\U2Actividad3-171G0250\Views\Home\cortos.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<U2Actividad3_171G0250.Models.ViewModels.DatosCortoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591