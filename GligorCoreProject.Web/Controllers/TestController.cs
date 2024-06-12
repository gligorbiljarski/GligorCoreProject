using GligorCoreProject.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GligorCoreProject.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Gligor Programerot",
                DateOfBirth = new DateTime(1987,08,11)
            };
            return View(data);
        }
    }
}
