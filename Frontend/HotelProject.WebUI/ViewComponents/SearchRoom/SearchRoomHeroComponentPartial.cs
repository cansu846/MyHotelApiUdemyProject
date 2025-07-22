using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace RapidApiHotelProject.ViewComponents.DefaultViewComponents
{
    public class SearchRoomHeroComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public SearchRoomHeroComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

    //        var client = new HttpClient();
    //        var request = new HttpRequestMessage
    //        {
    //            Method = HttpMethod.Get,
    //            RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query=turkey"),
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
    //            Console.WriteLine(body);
    //            var values = JsonConvert.DeserializeObject<ResultDestinationDto>(body);
    //            ViewBag.cities = values.data.Select(x => new SelectListItem
    //            {
    //                Text = x.city_name,
    //                Value = x.dest_id.ToString()
    //            }).ToList();
    //        }


            return View();
        }
    }
}