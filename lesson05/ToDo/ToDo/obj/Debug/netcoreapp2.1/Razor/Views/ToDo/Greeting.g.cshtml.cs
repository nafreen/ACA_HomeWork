#pragma checksum "C:\Users\mfhos\Documents\ACA\lesson05\ToDo\ToDo\Views\ToDo\Greeting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "686447321d34ea5fc02b34281d089692e32e1463"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDo_Greeting), @"mvc.1.0.view", @"/Views/ToDo/Greeting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ToDo/Greeting.cshtml", typeof(AspNetCore.Views_ToDo_Greeting))]
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
#line 1 "C:\Users\mfhos\Documents\ACA\lesson05\ToDo\ToDo\Views\_ViewImports.cshtml"
using ToDoApp;

#line default
#line hidden
#line 2 "C:\Users\mfhos\Documents\ACA\lesson05\ToDo\ToDo\Views\_ViewImports.cshtml"
using ToDoApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686447321d34ea5fc02b34281d089692e32e1463", @"/Views/ToDo/Greeting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea8e16a145f22812a50ceaab5d0af8989b02e9dc", @"/Views/_ViewImports.cshtml")]
    public class Views_ToDo_Greeting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\mfhos\Documents\ACA\lesson05\ToDo\ToDo\Views\ToDo\Greeting.cshtml"
  
    ViewData["Title"] = "MyView";
    

#line default
#line hidden
            BeginContext(64, 26, true);
            WriteLiteral("<h2>MyView</h2>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(91, 5, false);
#line 8 "C:\Users\mfhos\Documents\ACA\lesson05\ToDo\ToDo\Views\ToDo\Greeting.cshtml"
Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(96, 44, true);
            WriteLiteral("  World (from the view)\r\n</p>\r\n\r\n<p>\r\n\r\n    ");
            EndContext();
            BeginContext(141, 27, false);
#line 13 "C:\Users\mfhos\Documents\ACA\lesson05\ToDo\ToDo\Views\ToDo\Greeting.cshtml"
Write(ViewData["SpanishGreeting"]);

#line default
#line hidden
            EndContext();
            BeginContext(168, 41, true);
            WriteLiteral("  World (in Spanish)\r\n\r\n</p>\r\n<p>\r\n\r\n    ");
            EndContext();
            BeginContext(210, 23, false);
#line 18 "C:\Users\mfhos\Documents\ACA\lesson05\ToDo\ToDo\Views\ToDo\Greeting.cshtml"
Write(ViewBag.SpanishGreeting);

#line default
#line hidden
            EndContext();
            BeginContext(233, 36, true);
            WriteLiteral("  World (in Spanish again)\r\n\r\n</p>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
