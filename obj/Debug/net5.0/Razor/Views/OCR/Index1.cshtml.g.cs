#pragma checksum "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\OCR\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe1fc43c3302c0ac24e715305aeb0b1fd3e4d5ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OCR_Index1), @"mvc.1.0.view", @"/Views/OCR/Index1.cshtml")]
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
#line 1 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\_ViewImports.cshtml"
using Detectron;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\_ViewImports.cshtml"
using Detectron.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\_ViewImports.cshtml"
using Detectron.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\OCR\Index1.cshtml"
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\OCR\Index1.cshtml"
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe1fc43c3302c0ac24e715305aeb0b1fd3e4d5ee", @"/Views/OCR/Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46517d4db7c4af83de76d6de3c196cf6c8706c87", @"/Views/_ViewImports.cshtml")]
    public class Views_OCR_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\OCR\Index1.cshtml"
  
    ViewBag.Title = "OCR";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 10 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\OCR\Index1.cshtml"
 if (ViewBag.RecognitionResult != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Results:</h3>\n");
            WriteLiteral("    <p><strong>Text:</strong></p>\n");
#nullable restore
#line 15 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\OCR\Index1.cshtml"
     foreach (var region in ViewBag.RecognitionResult.Regions)
    {
        foreach (var line in region.Lines)
        {
            foreach (var word in line.Words)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>");
#nullable restore
#line 21 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\OCR\Index1.cshtml"
                 Write(word.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\n");
#nullable restore
#line 22 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\OCR\Index1.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\n");
#nullable restore
#line 24 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\OCR\Index1.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\OCR\Index1.cshtml"
     
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
