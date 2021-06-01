using Microsoft.AspNetCore.Mvc;

namespace RecipeBox.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index() => View();
  }
}