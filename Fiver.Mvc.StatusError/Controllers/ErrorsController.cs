using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Fiver.Mvc.StatusError.Controllers
{
    public class ErrorsController : Controller
    {
        public IActionResult Index(int statusCode)
        {
            var feature = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();

            ViewBag.StatusCode = statusCode;
            ViewBag.OriginalPath = feature.OriginalPath;
            ViewBag.OriginalQueryString = feature.OriginalQueryString;

            return View();
        }
    }
}
