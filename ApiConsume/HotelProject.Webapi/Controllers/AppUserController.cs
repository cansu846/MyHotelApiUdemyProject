﻿using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HotelProject.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet("UserListWithWorkLocation")]
        public IActionResult UserListWithWorkLocation() {
        
            var values = _appUserService.TUserListWithWorkLocation();
           
            
            return Ok(values);
        }
    }
}
