#pragma checksum "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\SubscriberUpdate\SubscriberUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "204b67c7bca4c1e9f10e8915b2c7936e705b054f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SubscriberUpdate_SubscriberUpdate), @"mvc.1.0.view", @"/Views/SubscriberUpdate/SubscriberUpdate.cshtml")]
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
#line 1 "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\_ViewImports.cshtml"
using Water_Invoices_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\_ViewImports.cshtml"
using Water_Invoices_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"204b67c7bca4c1e9f10e8915b2c7936e705b054f", @"/Views/SubscriberUpdate/SubscriberUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6d39a749047f2bac5ed12164366551bcfebbbf9", @"/Views/_ViewImports.cshtml")]
    public class Views_SubscriberUpdate_SubscriberUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Water_Invoices_Project.Models.NwcSubscriberFile>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\SubscriberUpdate\SubscriberUpdate.cshtml"
 using (Html.BeginForm("UpdateRecordSub", "SubscriberUpdate", FormMethod.Post, new { @class = "form-horizontal", @dir = "rtl" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table"">
        <tr>
            <td>
                <label class=""control-label text-right"">رقم الهوية</label>
            </td>
            <td>
                <input type=""text"" name=""Code"" id=""Code"" class=""form-control"" />
            </td>
        </tr>
        <tr>
            <td>
                <label class=""control-label text-right"">الاسم</label>
            </td>
            <td>
                <input type=""text"" name=""Name"" id=""Name"" class=""form-control"" />
            </td>
        </tr>
        <tr>
            <td>
                <label class=""control-label text-right"">المدينة</label>
            </td>
            <td>
                <input type=""text"" name=""City"" id=""City"" class=""form-control"" />
            </td>
        </tr>
        <tr>
            <td>
                <label class=""control-label text-right"">الحي</label>
            </td>
            <td>
                <input type=""text"" name=""Area"" id=""Area"" class=""form-control"" />
 ");
            WriteLiteral(@"           </td>
        </tr>
        <tr>
            <td>
                <label class=""control-label text-right"">رقم الجوال</label>
            </td>
            <td>
                <input type=""text"" name=""Phone"" id=""Phone"" class=""form-control"" />
            </td>
        </tr>
    </table>
");
            WriteLiteral(@"    <div class=""form-group rtl"" style=""text-align: right; margin-right: 50px;"">
        <div style=""display: inline-block;"">
            <input type=""submit"" value=""حفظ"" class=""btn btn-primary""
                   style=""background-color: blue; font-size: 28px;"">
        </div>
        <div style=""display: inline-block;"">
            <input type=""button"" onclick=""clearTextboxes()"" value=""انهاء"" class=""btn btn-primary""
                   style=""background-color: darkred; font-size: 28px;"">
        </div>
    </div>
");
#nullable restore
#line 57 "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\SubscriberUpdate\SubscriberUpdate.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 62 "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\SubscriberUpdate\SubscriberUpdate.cshtml"
 if (TempData["SuccessMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">");
#nullable restore
#line 64 "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\SubscriberUpdate\SubscriberUpdate.cshtml"
                                Write(TempData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 65 "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\SubscriberUpdate\SubscriberUpdate.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\SubscriberUpdate\SubscriberUpdate.cshtml"
 if (TempData["Failed Message"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\" style=\"background-color:red; color:white;\">");
#nullable restore
#line 68 "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\SubscriberUpdate\SubscriberUpdate.cshtml"
                                                                           Write(TempData["Failed Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 69 "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\SubscriberUpdate\SubscriberUpdate.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    table {
        border-collapse: collapse;
        width: 100%;
    }

    th, td {
        padding: 8px;
        white-space: nowrap;
        text-align: center;
        overflow: hidden;
        text-overflow: ellipsis;
        font-size: 13px;
    }


    th {
        background-color: blue;
        color: white;
    }

    .rtl {
        direction: rtl;
        font-family: 'Arabic Typesetting';
    }

    .table-container {
        max-height: 100%;
        overflow-y: auto;
    }
</style>

<script>
    function clearTextboxes() {
        $('#Code').val("""");
        $('#Name').val("""");
        $('#City').val("""");
        $('#Area').val("""");
        $('#Phone').val("""");
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Water_Invoices_Project.Models.NwcSubscriberFile> Html { get; private set; }
    }
}
#pragma warning restore 1591
