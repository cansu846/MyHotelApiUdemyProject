#pragma checksum "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_AvailableRoomPartial\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "39130d4f4f837db2c0fc16329bd30e4805ca4a04b97d1246a5a2afeef9241572"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Shared_Components__AvailableRoomPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_AvailableRoomPartial/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"39130d4f4f837db2c0fc16329bd30e4805ca4a04b97d1246a5a2afeef9241572", @"/Views/Shared/Components/_AvailableRoomPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e5bbcc5772ab5004f39237b0c6305f46dbeb26edf4fd7acfbe02d276c24abbe9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Shared_Components__AvailableRoomPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_AvailableRoomPartial\Default.cshtml"
       List<ResultRoomDto>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-xxl py-5"">
    <div class=""container"">
        <div class=""text-center wow fadeInUp"" data-wow-delay=""0.1s"">
            <h6 class=""section-title text-center text-primary text-uppercase"">Odalarimiz</h6>
            <h1 class=""mb-5"">Odalarimizi <span class=""text-primary text-uppercase"">Keşfedin</span></h1>
        </div>
        <div class=""row g-4"">
");
#nullable restore
#line 9 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_AvailableRoomPartial\Default.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                <div class=""col-lg-4 col-md-6 wow fadeInUp"" data-wow-delay=""0.1s"">
                    <div class=""room-item shadow rounded overflow-hidden"">
                        <div class=""position-relative"">
                            <img class=""img-fluid""");
            BeginWriteAttribute("src", " src=\"", 731, "\"", 757, 1);
            WriteAttributeValue("", 737, 
#nullable restore
#line 14 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_AvailableRoomPartial\Default.cshtml"
                                                         item.RoomCoverImage

#line default
#line hidden
#nullable disable
            , 737, 20, false);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 758, "\"", 764, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <small class=\"position-absolute start-0 top-100 translate-middle-y bg-primary text-white rounded py-1 px-3 ms-4\">$ ");
            Write(
#nullable restore
#line 15 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_AvailableRoomPartial\Default.cshtml"
                                                                                                                                                item.Price

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("/Night</small>\r\n                        </div>\r\n                        <div class=\"p-4 mt-2\">\r\n                            <div class=\"d-flex justify-content-between mb-3\">\r\n                                <h5 class=\"mb-0\">");
            Write(
#nullable restore
#line 19 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_AvailableRoomPartial\Default.cshtml"
                                                  item.Title

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</h5>
                                <div class=""ps-2"">
                                    <small class=""fa fa-star text-primary""></small>
                                    <small class=""fa fa-star text-primary""></small>
                                    <small class=""fa fa-star text-primary""></small>
                                    <small class=""fa fa-star text-primary""></small>
                                    <small class=""fa fa-star text-primary""></small>
                                </div>
                            </div>
                            <div class=""d-flex mb-3"">
                                <small class=""border-end me-3 pe-3""><i class=""fa fa-bed text-primary me-2""></i>3 Bed</small>
                                <small class=""border-end me-3 pe-3""><i class=""fa fa-bath text-primary me-2""></i>2 Bath</small>
                                <small><i class=""fa fa-wifi text-primary me-2""></i>Wifi</small>
                            </div>
                      ");
            WriteLiteral("      <p class=\"text-body mb-3\">");
            Write(
#nullable restore
#line 33 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_AvailableRoomPartial\Default.cshtml"
                                                       item.Description

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                            <div class=\"d-flex justify-content-between\">\r\n                                <a class=\"btn btn-sm btn-primary rounded py-2 px-4\"");
            BeginWriteAttribute("href", " href=\"", 2393, "\"", 2400, 0);
            EndWriteAttribute();
            WriteLiteral(">Detayına Git</a>\r\n                                <a class=\"btn btn-sm btn-dark rounded py-2 px-4\"");
            BeginWriteAttribute("href", " href=\"", 2500, "\"", 2507, 0);
            EndWriteAttribute();
            WriteLiteral(">Rezervasyon Yap</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 41 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_AvailableRoomPartial\Default.cshtml"

            }

#line default
#line hidden
#nullable disable

#nullable restore
#line 43 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_AvailableRoomPartial\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                <div class=""col-lg-4 col-md-6 wow fadeInUp"" data-wow-delay=""0.1s"">
                    <div class=""room-item shadow rounded overflow-hidden"">
                        <div class=""position-relative"">
                            <img class=""img-fluid""");
            BeginWriteAttribute("src", " src=\"", 2991, "\"", 3017, 1);
            WriteAttributeValue("", 2997, 
#nullable restore
#line 48 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_AvailableRoomPartial\Default.cshtml"
                                                         item.RoomCoverImage

#line default
#line hidden
#nullable disable
            , 2997, 20, false);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3018, "\"", 3024, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <small class=\"position-absolute start-0 top-100 translate-middle-y bg-primary text-white rounded py-1 px-3 ms-4\">$ ");
            Write(
#nullable restore
#line 49 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_AvailableRoomPartial\Default.cshtml"
                                                                                                                                                item.Price

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("/Night</small>\r\n                        </div>\r\n                        <div class=\"p-4 mt-2\">\r\n                            <div class=\"d-flex justify-content-between mb-3\">\r\n                                <h5 class=\"mb-0\">");
            Write(
#nullable restore
#line 53 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_AvailableRoomPartial\Default.cshtml"
                                                  item.Title

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</h5>
                                <div class=""ps-2"">
                                    <small class=""fa fa-star text-primary""></small>
                                    <small class=""fa fa-star text-primary""></small>
                                    <small class=""fa fa-star text-primary""></small>
                                    <small class=""fa fa-star text-primary""></small>
                                    <small class=""fa fa-star text-primary""></small>
                                </div>
                            </div>
                            <div class=""d-flex mb-3"">
                                <small class=""border-end me-3 pe-3""><i class=""fa fa-bed text-primary me-2""></i>3 Bed</small>
                                <small class=""border-end me-3 pe-3""><i class=""fa fa-bath text-primary me-2""></i>2 Bath</small>
                                <small><i class=""fa fa-wifi text-primary me-2""></i>Wifi</small>
                            </div>
                      ");
            WriteLiteral("      <p class=\"text-body mb-3\">");
            Write(
#nullable restore
#line 67 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_AvailableRoomPartial\Default.cshtml"
                                                       item.Description

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                            <div class=\"d-flex justify-content-between\">\r\n                                <a class=\"btn btn-sm btn-primary rounded py-2 px-4\"");
            BeginWriteAttribute("href", " href=\"", 4653, "\"", 4660, 0);
            EndWriteAttribute();
            WriteLiteral(">Detayına Git</a>\r\n                                <a class=\"btn btn-sm btn-dark rounded py-2 px-4\"");
            BeginWriteAttribute("href", " href=\"", 4760, "\"", 4767, 0);
            EndWriteAttribute();
            WriteLiteral(">Rezervasyon Yap</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 75 "C:\Users\Cansu\source\repos\MyHotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_AvailableRoomPartial\Default.cshtml"

            }

#line default
#line hidden
#nullable disable

            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultRoomDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
