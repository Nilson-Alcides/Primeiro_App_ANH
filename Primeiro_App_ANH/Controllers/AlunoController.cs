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
        public IActionResult Teste()
        {
            TempData["MSG_EX"] = "Mensagem do TempData";
            return RedirectToAction("Resultado");
        }
        public IActionResult Resultado()
        {
            if (TempData["MSG_EX"] != null)
                ViewBag.Exemplo = "Aluno Anhaguera MB";
            return View();

        }
    }
}
