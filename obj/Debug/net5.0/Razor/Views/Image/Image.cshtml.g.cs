#pragma checksum "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\Image\Image.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bedc8851a025d43c8544ce9492b26bf1b8d5014f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Image_Image), @"mvc.1.0.view", @"/Views/Image/Image.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bedc8851a025d43c8544ce9492b26bf1b8d5014f", @"/Views/Image/Image.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46517d4db7c4af83de76d6de3c196cf6c8706c87", @"/Views/_ViewImports.cshtml")]
    public class Views_Image_Image : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\Image\Image.cshtml"
  
    int no = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\Image\Image.cshtml"
 using (Html.BeginForm("Image", "Image", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h4 class=""text-bold-300""><label for=""formFileLg"" class=""form-label"">Select an image file to upload:</label></h4><br />
    <input type=""file"" name=""imageFile""  class=""form-control form-control-lg"" id=""formFileLg"" /><br />
    <input type=""submit"" value=""Upload"" class=""btn btn-primary btn-outline-black mt-2"" />
");
#nullable restore
#line 11 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\Image\Image.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 13 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\Image\Image.cshtml"
 if (Model != null && Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""text-center"">
        <h2>Detected Tags</h2>
        <div class=""row text-center mt-25"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">No</th>
                        <th scope=""col"">Attribute</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 26 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\Image\Image.cshtml"
                     foreach (string tag in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <th>");
#nullable restore
#line 29 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\Image\Image.cshtml"
                           Write(no);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                            <td>");
#nullable restore
#line 30 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\Image\Image.cshtml"
                           Write(tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 32 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\Image\Image.cshtml"
                        no = no + 1;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </div>\n");
#nullable restore
#line 38 "C:\Users\158648\Downloads\Detectron-master\Detectron-master\Detectron\Views\Image\Image.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
