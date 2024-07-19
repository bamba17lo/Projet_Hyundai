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
        
    }
}
