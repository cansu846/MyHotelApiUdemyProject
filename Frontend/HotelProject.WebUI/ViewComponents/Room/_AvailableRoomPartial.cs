using HotelProject.WebUI.Dtos.RoomDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Room
{
    public class _AvailableRoomPartial : ViewComponent
    {
        
        private readonly IHttpClientFactory _httpClientFactory;

        public _AvailableRoomPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var client = _httpClientFactory.CreateClient();
            var result = await client.GetAsync("https://localhost:44358/api/Room\r\n");

            if (result.IsSuccessStatusCode) {
                var jsonData = await result.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultRoomDto>>(jsonData);
                return View(values);
            }
              
            return View();
        }
    }
}
