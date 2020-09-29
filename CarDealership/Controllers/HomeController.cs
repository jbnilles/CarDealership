using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]//"Gets" 
    public ActionResult Index()
    {
      return View();
    }

  }
}