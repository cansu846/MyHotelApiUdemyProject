#pragma checksum "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Role\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ead15dec1fc405f88e6c97db079c21b0b6e649d0535ff3aac8742f015d951355"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Role_Index), @"mvc.1.0.view", @"/Views/Role/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ead15dec1fc405f88e6c97db079c21b0b6e649d0535ff3aac8742f015d951355", @"/Views/Role/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e5bbcc5772ab5004f39237b0c6305f46dbeb26edf4fd7acfbe02d276c24abbe9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Role_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Role\Index.cshtml"
       List<HotelProject.EntityLayer.Concrete.AppRole>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Role\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<h1>Rol Listesi</h1>\n\n<table class=\"table table-bordered\">\n    <tr>\n        <th>#</th>\n        <th>Rol Adı</th>\n        <th>Sil</th>\n        <th>Güncelle</th>\n    </tr>\n");
#nullable restore
#line 16 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Role\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\n            <td>");
            Write(
#nullable restore
#line 19 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Role\Index.cshtml"
                 item.Id

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\n            <td>");
            Write(
#nullable restore
#line 20 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Role\Index.cshtml"
                 item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 451, "\"", 483, 2);
            WriteAttributeValue("", 458, "/Role/DeleteRole/", 458, 17, true);
            WriteAttributeValue("", 475, 
#nullable restore
#line 21 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Role\Index.cshtml"
                                           item.Id

#line default
#line hidden
#nullable disable
            , 475, 8, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-danger\">Sil</a></td>\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 564, "\"", 596, 2);
            WriteAttributeValue("", 571, "/Role/UpdateRole/", 571, 17, true);
            WriteAttributeValue("", 588, 
#nullable restore
#line 22 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Role\Index.cshtml"
                                           item.Id

#line default
#line hidden
#nullable disable
            , 588, 8, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-success\">Güncelle</a></td>\n        </tr>\n");
#nullable restore
#line 24 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Role\Index.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</table>\n<a href=\"/Role/AddRole/\" class=\"btn mb-1 btn-rounded btn-outline-info\">Yeni Rol Girişi</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HotelProject.EntityLayer.Concrete.AppRole>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
