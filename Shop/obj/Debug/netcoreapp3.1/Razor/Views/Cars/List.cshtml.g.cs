#pragma checksum "C:\Users\Burious\source\repos\Shop\Shop\Views\Cars\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af75f050ff96ea6010d786af1cf4dac7212bd972"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_List), @"mvc.1.0.view", @"/Views/Cars/List.cshtml")]
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
#line 1 "C:\Users\Burious\source\repos\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af75f050ff96ea6010d786af1cf4dac7212bd972", @"/Views/Cars/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8698b1ec29562463bc33480ac52eac0346944c13", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Все автомобили</h1>\r\n<h3>");
#nullable restore
#line 2 "C:\Users\Burious\source\repos\Shop\Shop\Views\Cars\List.cshtml"
Write(Model.currCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<div class=\"row mt-5 mb-2\" >\r\n");
#nullable restore
#line 4 "C:\Users\Burious\source\repos\Shop\Shop\Views\Cars\List.cshtml"
      
        foreach (var car in Model.allCars)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-4\">\r\n            <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 218, "\"", 232, 1);
#nullable restore
#line 8 "C:\Users\Burious\source\repos\Shop\Shop\Views\Cars\List.cshtml"
WriteAttributeValue("", 224, car.img, 224, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 233, "\"", 248, 1);
#nullable restore
#line 8 "C:\Users\Burious\source\repos\Shop\Shop\Views\Cars\List.cshtml"
WriteAttributeValue("", 239, car.name, 239, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <h2>");
#nullable restore
#line 9 "C:\Users\Burious\source\repos\Shop\Shop\Views\Cars\List.cshtml"
           Write(car.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <p>");
#nullable restore
#line 10 "C:\Users\Burious\source\repos\Shop\Shop\Views\Cars\List.cshtml"
          Write(car.shortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Цена: ");
#nullable restore
#line 11 "C:\Users\Burious\source\repos\Shop\Shop\Views\Cars\List.cshtml"
                Write(car.price.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><a class=\"btn btn-warning\" href=\"#\">Подробнее</a></p>\r\n        </div>\r\n");
#nullable restore
#line 14 "C:\Users\Burious\source\repos\Shop\Shop\Views\Cars\List.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
