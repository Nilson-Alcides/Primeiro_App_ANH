using Microsoft.AspNetCore.Mvc;

namespace Primeiro_App_ANH.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.nota = "Aluno Nota 10";
            ViewData["Escola"] = "E.E. Anhaguera";
            return View();
        }
    }
}
