using Microsoft.AspNetCore.Mvc;

namespace CompositeCRM.Controllers
{
    public class InvoicesDebtController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
