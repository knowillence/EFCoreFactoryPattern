#pragma checksum "C:\Projects\yaapiyal-dot-net\Knowillence.Yaapiyal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20840ae1e2c3e9e2cf2dbf651638a13b50b5a425"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20840ae1e2c3e9e2cf2dbf651638a13b50b5a425", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Knowillence.Yaapiyal.Model.ref_record_status>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projects\yaapiyal-dot-net\Knowillence.Yaapiyal\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Controller -> Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>This is the home page view from home controller.</p>\r\n    <p>");
#nullable restore
#line 10 "C:\Projects\yaapiyal-dot-net\Knowillence.Yaapiyal\Views\Home\Index.cshtml"
  Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 11 "C:\Projects\yaapiyal-dot-net\Knowillence.Yaapiyal\Views\Home\Index.cshtml"
     foreach (var record in Model)
    { 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>");
#nullable restore
#line 13 "C:\Projects\yaapiyal-dot-net\Knowillence.Yaapiyal\Views\Home\Index.cshtml"
       Write(record.record_status_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <h2>");
#nullable restore
#line 14 "C:\Projects\yaapiyal-dot-net\Knowillence.Yaapiyal\Views\Home\Index.cshtml"
       Write(record.record_status_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h3>");
#nullable restore
#line 15 "C:\Projects\yaapiyal-dot-net\Knowillence.Yaapiyal\Views\Home\Index.cshtml"
       Write(record.record_status_desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <hr />\r\n");
#nullable restore
#line 17 "C:\Projects\yaapiyal-dot-net\Knowillence.Yaapiyal\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Knowillence.Yaapiyal.Model.ref_record_status>> Html { get; private set; }
    }
}
#pragma warning restore 1591
