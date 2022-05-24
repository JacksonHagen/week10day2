using week10day2.FakeDb;
using week10day2.Models;

namespace week10day2.Services
{
  public class HousesService
  {
    internal List<House> Get()
    {
      return Database.Houses;
    }

    internal House Get(string id)
    {
      House house = Database.Houses.Find(h => h.Id == id);
      if (house == null)
      {
        throw new Exception("Invalid House ID");
      }
      return house;
    }

    internal House Create(House houseData)
    {
      Database.Houses.Add(houseData);
      return houseData;
    }

    internal House Edit(House houseData)
    {
      House original = Get(houseData.Id);
      original.Bathrooms = houseData.Bathrooms;
      original.Bedrooms = houseData.Bedrooms;
      original.Description = houseData.Description ?? original.Description;
      original.ImgUrl = houseData.ImgUrl ?? original.ImgUrl;
      original.Levels = houseData.Levels;
      original.Price = houseData.Price;
      original.Year = houseData.Year;

      return original;
    }

    internal void Delete(string id)
    {
      House found = Get(id);
      Database.Houses.Remove(found);
    }
  }
}