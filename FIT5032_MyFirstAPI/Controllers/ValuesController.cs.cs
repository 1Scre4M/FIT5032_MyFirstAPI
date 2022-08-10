using Microsoft.AspNetCore.Mvc;

namespace FIT5032_MyFirstAPI.Controllers
{
    public class ValuesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
