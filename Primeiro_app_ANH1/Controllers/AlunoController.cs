using Microsoft.AspNetCore.Mvc;

namespace Primeiro_app_ANH.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
