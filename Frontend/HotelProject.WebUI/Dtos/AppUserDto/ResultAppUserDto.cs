﻿using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebUI.Dtos.AppUserDto
{
    public class ResultAppUserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ImageUrl { get; set; }
        public string Gender { get; set; }
        public string WorkDepartment { get; set; }
        public int WorkLocationId { get; set; }
        public WorkLocation WorkLocation { get; set; }
    }
}
