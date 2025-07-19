using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.BookingDto
{
    public class CreateBookingDto
    {
        [Required(ErrorMessage = ("İsim giriniz "))]
        public string Name { get; set; }
        [Required(ErrorMessage = ("Mail giriniz "))]
        public string Mail { get; set; }
        [DataType(DataType.DateTime)]

        [Required(ErrorMessage = ("Checkin giriniz "))]
        public DateTime Checkin { get; set; }

        [Required(ErrorMessage = ("Checkout giriniz "))]
        [DataType(DataType.DateTime)]
        public DateTime CheckOut { get; set; }
        public string AdultCount { get; set; }
        public string ChildCount { get; set; }
        public string RoomCount { get; set; }
        public string SpecialRequest { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
