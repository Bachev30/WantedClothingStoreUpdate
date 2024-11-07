using Microsoft.AspNetCore.Mvc;

namespace WantedClothingStore.Controllers
{
    public class ComingSoonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
