#pragma checksum "C:\Users\mfhos\Documents\ACA\lesson05\ToDo\ToDo\Views\Shared\displayTemplates\Status.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a21872e58deb83de2ed49770d3633f2c91e4570e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_displayTemplates_Status), @"mvc.1.0.view", @"/Views/Shared/displayTemplates/Status.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/displayTemplates/Status.cshtml", typeof(AspNetCore.Views_Shared_displayTemplates_Status))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a21872e58deb83de2ed49770d3633f2c91e4570e", @"/Views/Shared/displayTemplates/Status.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea8e16a145f22812a50ceaab5d0af8989b02e9dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_displayTemplates_Status : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoApp.Models.Status>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(124, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(156, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\mfhos\Documents\ACA\lesson05\ToDo\ToDo\Views\Shared\displayTemplates\Status.cshtml"
   
    var color = "transparent";

    if (Model.Id == 1)
    {
        color = "red";
    }

    if (Model.Id == 2)
    {
        color = "yellow";
    }

    if (Model.Id == 3)
    {
        color = "green";
    }

#line default
#line hidden
            BeginContext(395, 7, true);
            WriteLiteral("\r\n<span");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 402, "\"", 436, 4);
            WriteAttributeValue("", 410, "background-color", 410, 16, true);
            WriteAttributeValue(" ", 426, ":", 427, 2, true);
#line 27 "C:\Users\mfhos\Documents\ACA\lesson05\ToDo\ToDo\Views\Shared\displayTemplates\Status.cshtml"
WriteAttributeValue(" ", 428, color, 429, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 435, ";", 435, 1, true);
            EndWriteAttribute();
            BeginContext(437, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(439, 11, false);
#line 27 "C:\Users\mfhos\Documents\ACA\lesson05\ToDo\ToDo\Views\Shared\displayTemplates\Status.cshtml"
                                    Write(Model.Value);

#line default
#line hidden
            EndContext();
            BeginContext(450, 7, true);
            WriteLiteral("</span>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoApp.Models.Status> Html { get; private set; }
    }
}
#pragma warning restore 1591