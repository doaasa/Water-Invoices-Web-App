#pragma checksum "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\InvoiceRegisteration\InvoiceRegisteration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12cdd0c36ae86009ca8d3045a14bbff0d3e662be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InvoiceRegisteration_InvoiceRegisteration), @"mvc.1.0.view", @"/Views/InvoiceRegisteration/InvoiceRegisteration.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12cdd0c36ae86009ca8d3045a14bbff0d3e662be", @"/Views/InvoiceRegisteration/InvoiceRegisteration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6d39a749047f2bac5ed12164366551bcfebbbf9", @"/Views/_ViewImports.cshtml")]
    public class Views_InvoiceRegisteration_InvoiceRegisteration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Water_Invoices_Project.Models.NwcInvoice>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\InvoiceRegisteration\InvoiceRegisteration.cshtml"
 using (Html.BeginForm("SaveInvoice", "InvoiceRegisteration", FormMethod.Post, new { @class = "form-horizontal", @dir = "rtl" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table"">
        <tr>
            <td>
                <label class=""control-label text-right"">رقم الفاتورة</label>
            </td>
            <td>
                <input type=""text"" name=""NwcInvoicesNo"" id=""NwcInvoicesNo"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 452, "\"", 480, 1);
#nullable restore
#line 10 "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\InvoiceRegisteration\InvoiceRegisteration.cshtml"
WriteAttributeValue("", 460, Model.NwcInvoicesNo, 460, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
            </td>
            <td>
                <label class=""control-label text-right"">تاريخ الفاتورة</label>
            </td>
            <td>
                <input type=""text"" name=""NwcInvoicesDate"" id=""NwcInvoicesDate"" class=""form-control"" />
            </td>
        </tr>
        <tr>
            <td>
                <label class=""control-label text-right"">من تاريخ</label>
            </td>
            <td>
                <input type=""text"" name=""NwcInvoicesFrom"" id=""NwcInvoicesFrom"" class=""form-control"" />
            </td>
            <td>
                <label class=""control-label text-right"">إلى تاريخ</label>
            </td>
            <td>
                <input type=""text"" name=""NwcInvoicesTo"" id=""NwcInvoicesTo"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1269, "\"", 1297, 1);
#nullable restore
#line 30 "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\InvoiceRegisteration\InvoiceRegisteration.cshtml"
WriteAttributeValue("", 1277, Model.NwcInvoicesTo, 1277, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
            </td>

        </tr>
        <tr>
            <td>
                <label class=""control-label text-right"">رقم الأشتراك</label>
            </td>
            <td>
                <input type=""text"" name=""NwcInvoicesSubscriptionNo"" id=""NwcInvoicesSubscriptionNo"" class=""form-control"" />
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <label class=""control-label text-right"">هوية المشترك</label>
            </td>
            <td>
                <input type=""text"" name=""NwcInvoicesSubscriberNo"" id=""NwcInvoicesSubscriberNo"" class=""form-control"" />
            </td>
            <td>
                <label class=""control-label text-right"">الأسم</label>
            </td>
            <td>
                <input type=""text"" name=""SubscriberName"" id=""SubscriberName"" class=""form-control"" />
            </td>

        </tr>

        <tr>
            <td>
                <lab");
            WriteLiteral(@"el class=""control-label text-right"">القراءة السابقة</label>
            </td>
            <td>
                <input type=""text"" name=""NwcInvoicesPreviousConsumptionAmount"" id=""NwcInvoicesPreviousConsumptionAmount""
                       class=""form-control"" />
            </td>
            <td>
                <label class=""control-label text-right"">القراءة الحالية</label>
            </td>
            <td>
                <input type=""text"" name=""NwcInvoicesCurrentConsumptionAmount"" id=""NwcInvoicesCurrentConsumptionAmount"" class=""form-control"" />
            </td>

        </tr>

        <tr>
            <td>
                <label class=""control-label text-right"">كمية الأستهلاك</label>
            </td>
            <td>
                <input type=""text"" name=""NwcInvoicesAmountConsumption"" id=""NwcInvoicesAmountConsumption"" class=""form-control"" />
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>

        <tr>
  ");
            WriteLiteral(@"          <td>
                <label class=""control-label text-right"">هل يوجد صرف صحي</label>
            </td>
            <td>
                <input type=""text"" name=""NwcInvoicesIsThereSanitation"" id=""NwcInvoicesIsThereSanitation"" class=""form-control"" />
            </td>
            <td>
                <label class=""control-label text-right"">عدد الوحدات</label>
            </td>
            <td>
                <input type=""text"" name=""Unit"" id=""Unit"" class=""form-control"" />
            </td>

        </tr>

        <tr>
            <td>
                <label class=""control-label text-right"">قيمة رسوم الخدمة</label>
            </td>
            <td>
                <input type=""text"" name=""NwcInvoicesServiceFee"" id=""NwcInvoicesServiceFee"" class=""form-control"" />
            </td>
            <td>
                <label class=""control-label text-right"">نسبة الضريبة</label>
            </td>
            <td>
                <input type=""text"" name=""NwcInvoicesTaxRate"" id=""NwcIn");
            WriteLiteral(@"voicesTaxRate"" class=""form-control"" />
            </td>

        </tr>

        <tr>
            <td>
                <label class=""control-label text-right"">قيمة استهلاك المياه</label>
            </td>
            <td>
                <input type=""text"" name=""NwcInvoicesConsumptionValue"" id=""NwcInvoicesConsumptionValue"" class=""form-control"" />
            </td>
            <td>
                <label class=""control-label text-right"">قيمة استهلاك الصرف الصحي</label>
            </td>
            <td>
                <input type=""text"" name=""NwcInvoicesWastewaterConsumptionValue"" id=""NwcInvoicesWastewaterConsumptionValue"" class=""form-control"" />
            </td>

        </tr>

        <tr>
            <td>
                <label class=""control-label text-right"">قيمة الفاتورة</label>
            </td>
            <td>
                <input type=""text"" name=""NwcInvoicesTotalInvoice"" id=""NwcInvoicesTotalInvoice"" class=""form-control"" />
            </td>
            <td>
         ");
            WriteLiteral(@"       <label class=""control-label text-right"">اجمالي الفاتورة</label>
            </td>
            <td>
                <input type=""text"" name=""NwcInvoicesTotalBill"" id=""NwcInvoicesTotalBill"" class=""form-control"" />
            </td>

        </tr>

    </table>
");
#nullable restore
#line 158 "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\InvoiceRegisteration\InvoiceRegisteration.cshtml"
     if (TempData["SuccessMessage"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success\">");
#nullable restore
#line 160 "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\InvoiceRegisteration\InvoiceRegisteration.cshtml"
                                    Write(TempData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 161 "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\InvoiceRegisteration\InvoiceRegisteration.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 162 "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\InvoiceRegisteration\InvoiceRegisteration.cshtml"
     if (TempData["Failed Message"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success\" style=\"background-color:red; color:white;\">");
#nullable restore
#line 164 "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\InvoiceRegisteration\InvoiceRegisteration.cshtml"
                                                                               Write(TempData["Failed Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 165 "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\InvoiceRegisteration\InvoiceRegisteration.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""form-group rtl"" style=""text-align: right; margin-right: 50px;"">
        <div style=""display: inline-block;"">
            <button type=""submit"" class=""btn btn-primary"" style=""background-color: blue; font-size: 28px;"">حفظ</button>
        </div>
        <div style=""display: inline-block; margin-left: 10px; margin-right: 20px;"">
            <button type=""submit"" onclick=""clearTextboxes()"" class=""btn btn-primary"" style=""background-color: darkred; font-size: 28px;"">انهاء</button>
        </div>
    </div>
");
#nullable restore
#line 174 "C:\Users\Electronica Care\Desktop\Project Task\Water Invoices Project\Water Invoices Project\Views\InvoiceRegisteration\InvoiceRegisteration.cshtml"
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


<script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>
<script>
    $(document).ready(function () {
        $(""#NwcInvoicesSubscriptionNo"").change(function () {
            var newValue = $(this).val();
            myFunction(newValue);
        });
    });

    function myFunction(newValue) {
        $.post(""/InvoiceRegisteration/GetSubrData"",
            { subscriberNo: newValue })
            .done(function (response) {
                $('#Nwc");
            WriteLiteral(@"InvoicesSubscriberNo').val(response.data1);
                $('#NwcInvoicesIsThereSanitation').val(response.data2);
                $('#NwcInvoicesPreviousConsumptionAmount').val(response.data3);
                $('#Unit').val(response.data4);
                $('#SubscriberName').val(response.data5);
                $('#NwcInvoicesAmountConsumption').val(response.data6);

            })
            .fail(function (xhr, status, error) {
                console.error(xhr.responseText);
                console.error(xhr.status);
            });
    }

    $(document).ready(function () {
        $(""#NwcInvoicesCurrentConsumptionAmount"").change(function () {
            var newValue = $(this).val();
            var lastvalue = $(""#NwcInvoicesPreviousConsumptionAmount"").val();
            Usage(newValue, lastvalue);
        });
    });

    function Usage(newValue, lastvalue) {
        $.post(""/InvoiceRegisteration/CalculateUsage"",
            {
                Now: newValue,
             ");
            WriteLiteral(@"   last: lastvalue
            })
            .done(function (response) {
                $('#NwcInvoicesAmountConsumption').val(response.data6);
            })
            .fail(function (xhr, status, error) {
                console.error(xhr.responseText);
                console.error(xhr.status);
            });
    }

    $(document).ready(function () {
        $(""#NwcInvoicesTaxRate"").change(function () {
            var wateruse = $(""#NwcInvoicesAmountConsumption"").val();
            var unitno = $(""#Unit"").val();
            var serviceuse = $(""#NwcInvoicesServiceFee"").val();
            var percuse = $(""#NwcInvoicesTaxRate"").val();
            var santinuse = $(""#NwcInvoicesIsThereSanitation"").val();

            Prices(wateruse, unitno, serviceuse, percuse, santinuse);
        });
    });

    function Prices(water, usage, serviceuse, percuse, santinause) {
        $.post(""/InvoiceRegisteration/CalculateTax"",
            {
                water: water,
                uni");
            WriteLiteral(@"t: usage,
                ServiceFee: serviceuse,
                Serviceperc: percuse,
                santinuse: santinause
            }).done(function (response) {
                $('#NwcInvoicesConsumptionValue').val(response.data1);
                $('#NwcInvoicesWastewaterConsumptionValue').val(response.data2);
                $('#NwcInvoicesTotalInvoice').val(response.data3);
                $('#NwcInvoicesTotalBill').val(response.data4);
            })
            .fail(function (xhr, status, error) {
                console.error(xhr.responseText);
                console.error(xhr.status);
            });
    }
    function clearTextboxes() {
        $('#NwcInvoicesNo').val("""");
        $('#NwcInvoicesDate').val("""");
        $('#NwcInvoicesFrom').val("""");
        $('#NwcInvoicesTo').val("""");
        $('#Unit').val("""");
        $('#NwcInvoicesSubscriptionNo').val("""");
        $('#NwcInvoicesSubscriberNo').val("""");
        $('#SubscriberName').val("""");
        $('#NwcInvoicesP");
            WriteLiteral(@"reviousConsumptionAmount').val("""");
        $('#NwcInvoicesCurrentConsumptionAmount').val("""");
        $('#NwcInvoicesAmountConsumption').val("""");
        $('#NwcInvoicesServiceFee').val("""");
        $('#NwcInvoicesTaxRate').val("""");
        $('#NwcInvoicesIsThereSanitation').val("""");
        $('#NwcInvoicesConsumptionValue').val("""");
        $('#NwcInvoicesWastewaterConsumptionValue').val("""");
        $('#NwcInvoicesTotalInvoice').val("""");
        $('#NwcInvoicesTaxValue').val("""");
        $('#NwcInvoicesTotalBill').val("""");
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Water_Invoices_Project.Models.NwcInvoice> Html { get; private set; }
    }
}
#pragma warning restore 1591