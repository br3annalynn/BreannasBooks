using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BreannasBooks.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Books()
        {
            var books = BookConstants.BooksJson;
            return JsonObject(books);
        }

        private ContentResult JsonObject(string jsonString)
        {
            var parsedJson = JsonConvert.DeserializeObject(jsonString);
            var formattedJson = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            return Content(formattedJson, "application/json");
        }
    }
}
