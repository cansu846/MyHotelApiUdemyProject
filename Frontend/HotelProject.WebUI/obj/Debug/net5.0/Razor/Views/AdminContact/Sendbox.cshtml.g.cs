#pragma checksum "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "20b2b883d21e96d6a1dbd25c9180bea47fbc264ea85746635c5ec83a786077ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_AdminContact_Sendbox), @"mvc.1.0.view", @"/Views/AdminContact/Sendbox.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Staff

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Testimonial

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ServiceDto

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.StaffDto

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.AboutDto

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RoomDto

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.TestimonialDto

#nullable disable
    ;
#nullable restore
#line 11 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.BookingDto

#nullable disable
    ;
#nullable restore
#line 12 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ContactDto

#nullable disable
    ;
#nullable restore
#line 13 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.GuestDto

#nullable disable
    ;
#nullable restore
#line 14 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.SendMessageDto

#nullable disable
    ;
#nullable restore
#line 15 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Mail

#nullable disable
    ;
#nullable restore
#line 16 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.WorkLocationDto

#nullable disable
    ;
#nullable restore
#line 17 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.AppUserDto

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"20b2b883d21e96d6a1dbd25c9180bea47fbc264ea85746635c5ec83a786077ee", @"/Views/AdminContact/Sendbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e5bbcc5772ab5004f39237b0c6305f46dbeb26edf4fd7acfbe02d276c24abbe9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_AdminContact_Sendbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml"
       List<ResultSendboxDto>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml"
  
    ViewData["Title"] = "Sendbox";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<div class=\"email-left-box\">\n    <a href=\"/AdminContact/AddSendMessage/\" class=\"btn btn-primary btn-block\">Yeni Mesaj Oluştur</a>\n    ");
            Write(
#nullable restore
#line 10 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml"
     await Html.PartialAsync("SideBarAdminContactPartial")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n    <h5 class=\"mt-5 m-b-10\">Kategoriler</h5>\n    ");
            Write(
#nullable restore
#line 12 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml"
     await Html.PartialAsync("SideBarAdminContactCategoryPartial")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"
</div>
<div class=""email-right-box"">
    <div role=""toolbar"" class=""toolbar"">
        <div class=""btn-group"">
            <button aria-expanded=""false"" data-toggle=""dropdown"" class=""btn btn-dark dropdown-toggle"" type=""button"">
                Gönderilen Mesajlar <span class=""caret m-l-5""></span>
            </button>
        </div>
    </div>
    <div class=""email-list m-t-15"">
");
#nullable restore
#line 23 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml"
         if(Model != null)
        {
            

#line default
#line hidden
#nullable disable

#nullable restore
#line 25 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <div class=\"message\">\n                    <a");
            BeginWriteAttribute("href", " href=\"", 963, "\"", 1027, 2);
            WriteAttributeValue("", 970, "/AdminContact/MessageDetailsBySendbox/", 970, 38, true);
            WriteAttributeValue("", 1008, 
#nullable restore
#line 28 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml"
                                                                    item.SendMessageID

#line default
#line hidden
#nullable disable
            , 1008, 19, false);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""col-mail col-mail-1"">
                            <div class=""email-checkbox"">
                                <input type=""checkbox"" id=""chk2"">
                                <label class=""toggle"" for=""chk2""></label>
                            </div><span class=""star-toggle ti-star""></span>
                        </div>
                        <div class=""col-mail col-mail-2"">
                            <div class=""subject""><b>Konu: ");
            Write(
#nullable restore
#line 36 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml"
                                                           item.Title

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</b> Alıcı: ");
            Write(
#nullable restore
#line 36 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml"
                                                                                  item.ReceiverName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\n                            <div class=\"date\">");
            Write(
#nullable restore
#line 37 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml"
                                                ((DateTime)item.Date).ToString("dd-MMM-yyyy")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\n                        </div>\n                    </a>\n                </div>\n");
#nullable restore
#line 41 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml"
            }

#line default
#line hidden
#nullable disable

#nullable restore
#line 41 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml"
             
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("      \n    </div>\n</div>\n\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultSendboxDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
