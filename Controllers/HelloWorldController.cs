using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller {
    // GET
    public IActionResult Index() {
        return View();
    }

    //GET: helloworld/Welcome
    public IActionResult Welcome() {
        return View();
    }
}