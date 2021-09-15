using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class PackageDetailController : Controller
  {
  //   [HttpGet("/items")]
  //   public ActionResult Index()
  //   {
  //     List<Item> allItems = Item.GetAll();
  //     return View(allItems);
  //   }

    [HttpGet("/parcel/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/Index")]
    public ActionResult Index(int length, int width, int height, int weight, int dimension, int shippingCost)
    {
      Parcel newParcel = new Parcel(length, width, height, weight, dimension, shippingCost);
      newParcel.Length = length;
      newParcel.Width = width;
      newParcel.Height = height;
      newParcel.Weight = weight;
      newParcel.ShippingCost = shippingCost;
      int volume = newParcel.Volume();
      int cost = newParcel.CostToShip();
      volume = dimension;
      cost = shippingCost;
      return View(newParcel);
    }

  //   [HttpPost("/items")]
  //   public ActionResult Create(string description)
  //   {
  //     Item myItem = new Item(description);
  //     return RedirectToAction("Index");
  //   }
  }

}