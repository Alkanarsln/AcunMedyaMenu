using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaMenu.Controllers
{
    public class WeatherController : Controller
    {
        public async Task<IActionResult> Index()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weather-api-by-any-city.p.rapidapi.com/weather/Ankara"),
                Headers =
    {
        { "x-rapidapi-key", "22d6712382msh716c5d89dddeb24p1ea07fjsn0128036e7670" },
        { "x-rapidapi-host", "weather-api-by-any-city.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
            return View();
        }
    }
}
