using Microsoft.AspNetCore.Mvc;

namespace EventHanteringUppgift.Controllers
{
    [Route("[controller]")]
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
