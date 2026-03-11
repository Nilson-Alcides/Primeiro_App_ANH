using Microsoft.AspNetCore.Mvc;

namespace Primeiro_App_ANH.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
