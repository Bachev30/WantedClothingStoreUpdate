using Microsoft.AspNetCore.Mvc;

namespace WantedClothingStore.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
