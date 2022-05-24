using week10day2.FakeDb;
using week10day2.Models;

namespace week10day2.Services
{
  public class CarsService
  {
    internal List<Car> Get()
    {
      return Database.Cars;
    }

    internal Car Get(string id)
    {
      Car car = Database.Cars.Find(c => c.Id == id);
      if (car == null)
      {
        throw new Exception("Invalid Car Id");
      }
      return car;
    }
    internal Car Create(Car newCar)
    {
      Database.Cars.Add(newCar);
      return newCar;
    }

    internal Car Edit(Car carData)
    {
      Car original = Get(carData.Id);
      original.Year = carData.Year;
      original.Price = carData.Price;
      original.Model = carData.Model ?? original.Model;
      original.Make = carData.Make ?? original.Make;
      original.ImgUrl = carData.ImgUrl ?? original.ImgUrl;
      original.Description = carData.Description ?? original.Description;

      return original;
    }

    internal void Delete(string id)
    {
      Car found = Get(id);
      Database.Cars.Remove(found);
    }
  }
}