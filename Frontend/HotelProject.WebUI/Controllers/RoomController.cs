using HotelProject.WebUI.Dtos.RoomDto;
using HotelProject.WebUI.Models.SearchRoom;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiHotelProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class RoomController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;


        public RoomController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetSearchHotelList(HotelSearchViewModel hotelSearchViewModel)
        {
            ViewBag.v1 = "Otellerimiz";
            ViewBag.v2 = "Anasayfa";
            ViewBag.v3 = "Oteller";

            //        var client = new HttpClient();
            //        ResultCityViewModel destValues;
            //        var request = new HttpRequestMessage
            //        {
            //            Method = HttpMethod.Get,
            //            RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query={hotelSearchViewModel.City}"),
            //            Headers =
            //{
            //    { "x-rapidapi-key", "03fa2631c5mshecaf76e6c817307p1f5645jsn57a26179cdb1" },
            //    { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
            //},
            //        };
            //        using (var response = await client.SendAsync(request))
            //        {
            //            response.EnsureSuccessStatusCode();
            //            var body = await response.Content.ReadAsStringAsync();
            //            destValues = JsonConvert.DeserializeObject<ResultCityViewModel>(body);
            //            Console.WriteLine(body);
            //        }

            //        if (destValues != null)
            //        {
            //            for (var i = 0; i < destValues.data.Length; i++)
            //            {
            //                var city = destValues.data[0].dest_id;
            //                var request2 = new HttpRequestMessage
            //                {
            //                    Method = HttpMethod.Get,
            //                    RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels" +
            //                       $"?dest_id={city}" +
            //                       $"&search_type=CITY" +
            //                       $"&arrival_date={hotelSearchViewModel.ArrivalDate}" +
            //                       $"&departure_date={hotelSearchViewModel.DepartureDate}" +
            //                       $"&adults={hotelSearchViewModel.Adults}" +
            //                       $"&room_qty={hotelSearchViewModel.RoomQty}"),


            //                    Headers =
            //{
            //    { "x-rapidapi-key", "03fa2631c5mshecaf76e6c817307p1f5645jsn57a26179cdb1" },
            //    { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
            //},
            //                };
            //                using (var response = await client.SendAsync(request2))
            //                {
            //                    response.EnsureSuccessStatusCode();
            //                    var body = await response.Content.ReadAsStringAsync();
            //                    var roomList = JsonConvert.DeserializeObject<SearchRoomViewModel>(body);
            //                    Console.WriteLine(body);
            //                    return Ok(roomList.data.hotels);
            //                }
            //            }
            //        }

            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", "roomlist.json");
            var jsonData = System.IO.File.ReadAllText(filePath);
            var roomList = JsonConvert.DeserializeObject<List<ResultRoomListExampleData>>(jsonData);


            return View(roomList);
        }

        [HttpGet]
        public async Task<IActionResult> RoomList()
        {
            ViewBag.v1 = "Odalarımız";
            ViewBag.v2 = "Anasayfa";
            ViewBag.v3 = "Odalar";

            var client = _httpClientFactory.CreateClient();
            var result = await client.GetAsync("https://localhost:44358/api/Room\r\n");

            if (result.IsSuccessStatusCode)
            {
                var jsonData = await result.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultRoomDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
