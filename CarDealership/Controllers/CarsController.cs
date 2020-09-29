using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/Cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/Cars/new")]
    public ActionResult Form()
    {
      return View();
    }

    [HttpPost("/Cars")]
    public ActionResult Create(string makeModel, int price, int miles)
    {
      Car myCar = new Car(makeModel, price, miles);
      return RedirectToAction("Index");

    }
    // [HttpPost("/Cars/Delete")]
    // public ActionResult Clear()
    // {
    //   Car.ClearAll();
    //   //return View();
    //   return RedirectToAction("Index");

    // }
    [HttpGet("/Cars/Delete")]
    public ActionResult Delete()
    {
      Car.ClearAll();
      return View();
    }
  }
}