using Microsoft.AspNetCore.Mvc;

namespace HMTF.Controllers
{
    public class AuditTrailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
