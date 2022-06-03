using Microsoft.AspNetCore.Mvc;
using PlacesYouveBeen.Models;
using System.Collections.Generic;

namespace PlacesYouveBeen.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlace = Place.GetAll();
      return View(allPlace);
    }

    [Route("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      Place foundItem = Place.Find(id);
      return View(foundItem);
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityName, string time, string partySize)
    {
      Place myPlace = new Place(cityName, time, partySize);
      return RedirectToAction("Index");
    }

    [HttpPost("/places/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return View();
    }
  }
}