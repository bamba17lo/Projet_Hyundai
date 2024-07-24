using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Projet_Exam_hyundai.Controllers
{
    public class OffreController : Controller
    {
        public IActionResult Offre()
        {
            return View();
        }

        public IActionResult Details(string? model)
        {
            if (string.IsNullOrEmpty(model))
            {
                return BadRequest("Model parameter cannot be null or empty");
            }

            switch (model.ToLower())
            {
                case "sonata":
                    return View("Sonata");
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