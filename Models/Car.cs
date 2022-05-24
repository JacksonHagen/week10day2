using System.ComponentModel.DataAnnotations;

namespace week10day2.Models
{
  public class Car
  {
    public string Id { get; set; }

    [Required]
    [Range(1930, 2022)]
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Description { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int Price { get; set; }
    public string Color { get; set; }
    public string ImgUrl { get; set; } = "https://thiscatdoesnotexist.com";

    public Car(int year, string make, string model, string description, int price, string color, string imgUrl)
    {
      Id = Guid.NewGuid().ToString();
      Year = year;
      Make = make;
      Model = model;
      Description = description;
      Price = price;
      Color = color;
      ImgUrl = imgUrl;
    }
  }
}