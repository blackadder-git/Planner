using Microsoft.AspNetCore.Mvc;
using SacramentPlanner.Models;
using System.Diagnostics;

namespace SacramentPlanner.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["audio"] = getAudio();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private string getAudio()
        {
            var random = new Random();
            var list = new List<string> { "morning_break.mp3", "praise_man.mp3", "saints.mp3", "battle_hymn.mp3", "shepherd.mp3" };
            int index = random.Next(list.Count);

            return list[index];
        }
    }
}