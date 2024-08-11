using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace WebApplication9.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index(string name, int numTimes=4)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
