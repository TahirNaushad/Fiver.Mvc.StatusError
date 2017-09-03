using Microsoft.AspNetCore.Mvc;

namespace Fiver.Mvc.StatusError.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Throw404(int id) => StatusCode(404);

        public IActionResult Throw412(int id) => StatusCode(412);

        public IActionResult Throw500(int id) => StatusCode(500);
    }
}
