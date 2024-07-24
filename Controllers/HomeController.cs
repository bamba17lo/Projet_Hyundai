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
        public IActionResult Details(string? model)
        {
            if (string.IsNullOrEmpty(model))
            {
                return BadRequest("Model parameter cannot be null or empty");
            }

            switch (model.ToLower())
            {
                case "ioniq6":
                    return View("Ioniq6");
                case "tucson":
                    return View("Tucson");
                case "elantra":
                    return View("Elantra");
                case "santafe":
                    return View("SantaFe");
                default:
                    return NotFound();
            }
        }
    
}
}
