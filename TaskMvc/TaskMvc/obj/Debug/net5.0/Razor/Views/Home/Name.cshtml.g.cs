#pragma checksum "D:\Courses\TaskMvc\TaskMvc\Views\Home\Name.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44ad82b82fd6b97ac1e7fc6d6d118f780624cf0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Name), @"mvc.1.0.view", @"/Views/Home/Name.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44ad82b82fd6b97ac1e7fc6d6d118f780624cf0f", @"/Views/Home/Name.cshtml")]
    public class Views_Home_Name : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskMvc.Models.PersonViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"block-center\">\r\n    <h2>Hello, ");
#nullable restore
#line 4 "D:\Courses\TaskMvc\TaskMvc\Views\Home\Name.cshtml"
          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n</div>\r\n\r\n<style>\r\n    .block-center {\r\n        max-width: 300px;\r\n        margin-right: auto;\r\n        margin-left: auto;\r\n        margin-top: 200px;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskMvc.Models.PersonViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
