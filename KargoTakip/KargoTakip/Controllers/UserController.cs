using Microsoft.AspNetCore.Mvc;

namespace KargoTakip.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var deneme=DateTime.Now;
            return View();
        }
    }
}
