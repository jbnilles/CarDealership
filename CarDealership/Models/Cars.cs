using System;
using System.Collections.Generic;

namespace CarDealership.Models
{

  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    private static List<Car> _instances = new List<Car> { };
    // private string _makeModel;
    // private int _price;
    // private int _miles;
    // public static string Slogan(string slogan)
    // {
    //   return "Our cars sound like " + slogan;
    // }

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _instances.Add(this);
    }

    // public string MakeSound(string sound)
    // {
    //   return "Our " + _makeModel + " sound like " + sound;
    // }
    // public string GetMakeModel()
    // {
    //   return MakeModel;
    // }

    // public int GetPrice()
    // {
    //   return _price;
    // }

    // public int GetMiles()
    // {
    //   return _miles;
    // }

    // public bool WorthBuying(int maxPrice)
    // {
    //   return (_price <= maxPrice);
    // }
    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }

}
