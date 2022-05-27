using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesYouveBeen.Models;
using System.Collections.Generic;
using System;

namespace PlacesYouveBeen.TestTools
{
  [TestClass]
  public class PlaceTests : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }
    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace()
    {
      Place newPlace = new Place("test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
    [TestMethod]
    public void GetPlace_ReturnCityName()
    {
      string City = "test";
      Place newPlace = new Place(City);
      string result = newPlace.CityName;
      Assert.AreEqual(City,result);
    }
  }
}