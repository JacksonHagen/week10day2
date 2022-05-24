using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace week10day2.Models
{
  public class House
  {
    public string Id { get; set; }

    public int Bathrooms { get; set; }
    public int Bedrooms { get; set; }
    public string Description { get; set; }
    public string ImgUrl { get; set; } = "https://thiscatdoesnotexist.com";
    public int Levels { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int Price { get; set; }
    public int Year { get; set; }

    public House(int bathrooms, int bedrooms, string description, string imgUrl, int levels, int price, int year)
    {
      Id = Guid.NewGuid().ToString();
      Bathrooms = bathrooms;
      Bedrooms = bedrooms;
      Description = description;
      ImgUrl = imgUrl;
      Levels = levels;
      Price = price;
      Year = year;
    }
  }
}