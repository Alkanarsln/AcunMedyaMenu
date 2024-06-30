using AcunMedyaMenu.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AcunMedyaMenu.Controllers
{
    public class ImdbController : Controller
    {
        public async Task<IActionResult> MovieList()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
    {
        { "x-rapidapi-key", "22d6712382msh716c5d89dddeb24p1ea07fjsn0128036e7670" },
        { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ImdbViewModel>>(body);
                return View(values.ToList());
            }

        }

        public async Task<IActionResult> SeriesList()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/series/"),
                Headers =
    {
        { "x-rapidapi-key", "22d6712382msh716c5d89dddeb24p1ea07fjsn0128036e7670" },
        { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<SeriesViewModel.Class1>>(body);
                return View(values.ToList());
            }
        }
    }
}
