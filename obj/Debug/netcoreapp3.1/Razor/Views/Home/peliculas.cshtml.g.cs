#pragma checksum "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\U2Actividad3-171G0250\Views\Home\peliculas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90c192f8a583e19a3355321eebcaa5860fe3953c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_peliculas), @"mvc.1.0.view", @"/Views/Home/peliculas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90c192f8a583e19a3355321eebcaa5860fe3953c", @"/Views/Home/peliculas.cshtml")]
    public class Views_Home_peliculas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<U2Actividad3_171G0250.Models.Pelicula>>
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
#line 2 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\U2Actividad3-171G0250\Views\Home\peliculas.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"pelis\">\r\n");
#nullable restore
#line 6 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\U2Actividad3-171G0250\Views\Home\peliculas.cshtml"
     foreach (var peli in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <a class=\"imgPelicula\"");
            BeginWriteAttribute("href", " href=\"", 201, "\"", 230, 2);
            WriteAttributeValue("", 208, "/pelicula/", 208, 10, true);
#nullable restore
#line 10 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\U2Actividad3-171G0250\Views\Home\peliculas.cshtml"
WriteAttributeValue("", 218, peli.Nombre, 218, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "90c192f8a583e19a3355321eebcaa5860fe3953c3657", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 260, "~/images/portadas/", 260, 18, true);
#nullable restore
#line 11 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\U2Actividad3-171G0250\Views\Home\peliculas.cshtml"
AddHtmlAttributeValue("", 278, peli.Id.ToString(), 278, 21, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 299, "_p.jpg", 299, 6, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </a>\r\n            <div class=\"nombrePelicula\">\r\n                <p>");
#nullable restore
#line 14 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\U2Actividad3-171G0250\Views\Home\peliculas.cshtml"
              Write(peli.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 17 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\U2Actividad3-171G0250\Views\Home\peliculas.cshtml"




    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n   \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<U2Actividad3_171G0250.Models.Pelicula>> Html { get; private set; }
    }
}
#pragma warning restore 1591