using AppSettingsDI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AppSettingsDI.Controllers
{
    public class HomeController : Controller
    {
        private readonly HelloWorldObject _helloWorldObject;

        public HomeController(IOptions<HelloWorldObject> helloWorldObject)
        {
            _helloWorldObject = helloWorldObject.Value;
        }

        public IActionResult Index()
        {
            return View(_helloWorldObject);
        }
    }
}
