#pragma checksum "C:\Users\Mark\Documents\GitHub\DigitalScilicet\Views\_ViewStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66a702c130f3792be482cc919df5ed865f5c85b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__ViewStart), @"mvc.1.0.view", @"/Views/_ViewStart.cshtml")]
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
#line 1 "C:\Users\Mark\Documents\GitHub\DigitalScilicet\Views\_ViewImports.cshtml"
using Digital_Scilicet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mark\Documents\GitHub\DigitalScilicet\Views\_ViewImports.cshtml"
using Digital_Scilicet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mark\Documents\GitHub\DigitalScilicet\Views\_ViewImports.cshtml"
using Cursos.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Mark\Documents\GitHub\DigitalScilicet\Views\_ViewStart.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66a702c130f3792be482cc919df5ed865f5c85b7", @"/Views/_ViewStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8ee519cc10ae37ce34c40201c603ab95049223e", @"/Views/_ViewImports.cshtml")]
    public class Views__ViewStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Mark\Documents\GitHub\DigitalScilicet\Views\_ViewStart.cshtml"
  
    string user = this.Context.Session.GetString("UsuarioLogueado");

    if(string.IsNullOrEmpty(user))
        Layout = "_LayoutWithoutUser";
    else
        Layout = "_LayoutWithUser";

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
