using Microsoft.AspNetCore.Mvc;
using Projet_Exam_hyundai.Models;
using System.Diagnostics;

namespace Projet_Exam_hyundai.Controllers
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
            return View();
        }

        public IActionResult Entreprise()
        {
            return View();
        }

        public IActionResult Garantie()
        {
            return View();
        }

        public IActionResult Nouvelle()
        {
            return View();
        }

        public IActionResult Propos()
        {
            return View();
        }

        public IActionResult Service()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
