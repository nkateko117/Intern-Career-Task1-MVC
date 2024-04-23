using Microsoft.AspNetCore.Mvc;

namespace TheContactlessStore.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
