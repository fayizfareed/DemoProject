#pragma checksum "G:\New Project\Q3Code\DemoProject\DemoProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faa672ebb64ae26756c5a5fa06e1c98944e8db1f"
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
#nullable restore
#line 1 "G:\New Project\Q3Code\DemoProject\DemoProject\Views\_ViewImports.cshtml"
using DemoProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\New Project\Q3Code\DemoProject\DemoProject\Views\_ViewImports.cshtml"
using DemoProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\New Project\Q3Code\DemoProject\DemoProject\Views\Home\Index.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faa672ebb64ae26756c5a5fa06e1c98944e8db1f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e5c02823e45e62b1549594c69f9b51e88914cf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Data.DataTable>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\New Project\Q3Code\DemoProject\DemoProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"display-4\">Demo Application (Job)</h1>\r\n<table>\r\n    <thead>\r\n        <tr>\r\n");
#nullable restore
#line 10 "G:\New Project\Q3Code\DemoProject\DemoProject\Views\Home\Index.cshtml"
              
                int indheader = 0;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "G:\New Project\Q3Code\DemoProject\DemoProject\Views\Home\Index.cshtml"
             foreach (DataColumn col in Model.Columns)
            {
                if (indheader == 5)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>Complete</th>\r\n");
#nullable restore
#line 18 "G:\New Project\Q3Code\DemoProject\DemoProject\Views\Home\Index.cshtml"
                    indheader = 0;
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>");
#nullable restore
#line 22 "G:\New Project\Q3Code\DemoProject\DemoProject\Views\Home\Index.cshtml"
                   Write(col.ColumnName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 23 "G:\New Project\Q3Code\DemoProject\DemoProject\Views\Home\Index.cshtml"
                    indheader = indheader + 1;
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 30 "G:\New Project\Q3Code\DemoProject\DemoProject\Views\Home\Index.cshtml"
         foreach (DataRow row in Model.Rows)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
#nullable restore
#line 33 "G:\New Project\Q3Code\DemoProject\DemoProject\Views\Home\Index.cshtml"
                  
                    int ind = 0;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "G:\New Project\Q3Code\DemoProject\DemoProject\Views\Home\Index.cshtml"
                 foreach (DataColumn col in Model.Columns)
                {
                    if (ind == 5)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><a");
            BeginWriteAttribute("href", " href=\"", 999, "\"", 1062, 2);
            WriteAttributeValue("", 1006, "https://localhost:44302/Home/Update/", 1006, 36, true);
#nullable restore
#line 40 "G:\New Project\Q3Code\DemoProject\DemoProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 1042, row[col.ColumnName], 1042, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Complete</a></td>\r\n");
#nullable restore
#line 41 "G:\New Project\Q3Code\DemoProject\DemoProject\Views\Home\Index.cshtml"
                        ind = 0;
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 45 "G:\New Project\Q3Code\DemoProject\DemoProject\Views\Home\Index.cshtml"
                       Write(row[col.ColumnName]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 46 "G:\New Project\Q3Code\DemoProject\DemoProject\Views\Home\Index.cshtml"
                        ind = ind + 1;
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 50 "G:\New Project\Q3Code\DemoProject\DemoProject\Views\Home\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div class=\"text-center\">\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Data.DataTable> Html { get; private set; }
    }
}
#pragma warning restore 1591
