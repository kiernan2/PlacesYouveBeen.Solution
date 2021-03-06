using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
  public class Place 
  {
    public string CityName { get; set; }
    public string Time { get; set; }
    public string PartySize { get; set; }
    public int Id { get; }
    private static List<Place> _instances = new List<Place>();
    public Place (string cityName, string time, string partySize)
    {
      CityName = cityName;
      Time = time;
      PartySize = partySize;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static Place Find(int searchId)
    {
      return _instances[searchId - 1];
    }
    public static List<Place> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}