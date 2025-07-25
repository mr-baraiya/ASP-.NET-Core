using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using OMDB_API_Consume.Models;
  
namespace OMDB_API_Consume.Controllers
{
    public class MovieController : Controller
    {
        private readonly OMDbSettings _settings;

        public MovieController(IOptions<OMDbSettings> settings)
        {
            _settings = settings.Value;
        }

        // Movie List/Search View
        public async Task<IActionResult> List(string searchTerm, string year, string type)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                ViewBag.Error = "Please enter a search term.";
                return View(new List<MovieSummary>());
            }

            // If IMDb ID (like tt0241527), redirect to details with backlink params
            if (searchTerm.StartsWith("tt", StringComparison.OrdinalIgnoreCase))
            {
                return RedirectToAction("Index", new
                {
                    searchTerm = searchTerm,
                    prevSearch = "",
                    prevYear = "",
                    prevType = ""
                });
            }

            var queryParams = new List<string>
            {
                $"s={Uri.EscapeDataString(searchTerm)}",
                $"apikey={_settings.ApiKey}"
            };

            if (!string.IsNullOrEmpty(year))
                queryParams.Add($"y={year}");

            if (!string.IsNullOrEmpty(type))
                queryParams.Add($"type={type}");

            string url = $"{_settings.BaseUrl}?{string.Join("&", queryParams)}";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<MovieSearchResult>(json);

                if (result.Response == "False")
                {
                    ViewBag.Error = result.Error;
                    return View(new List<MovieSummary>());
                }

                ViewBag.SearchTerm = searchTerm;
                ViewBag.Year = year;
                ViewBag.Type = type;

                return View(result.Search);
            }
        }

        // Movie Details View (with backlink info)
        public async Task<IActionResult> Index(string searchTerm, string? prevSearch, string? prevYear, string? prevType)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return RedirectToAction("List");
            }

            var query = $"{_settings.BaseUrl}?apikey={_settings.ApiKey}&i={searchTerm}&plot=full";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(query);
                var json = await response.Content.ReadAsStringAsync();
                var movie = JsonConvert.DeserializeObject<Movie>(json);

                if (movie == null || string.IsNullOrEmpty(movie.Title))
                {
                    ViewBag.Error = "Movie not found!";
                    return RedirectToAction("List", new { searchTerm = prevSearch, year = prevYear, type = prevType });
                }

                // Pass backtracking info to the View
                ViewBag.SearchTerm = prevSearch;
                ViewBag.Year = prevYear;
                ViewBag.Type = prevType;

                return View(movie);
            }
        }
    }
}
