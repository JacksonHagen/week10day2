using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace week10day2.Models
{
  public class Job
  {
    public string Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImgUrl { get; set; }

    [Range(7.25, int.MaxValue)]
    public double Rate { get; set; }
    public Job(string title, string description, string imgUrl, double rate)
    {
      Id = Guid.NewGuid().ToString();
      Title = title;
      Description = description;
      ImgUrl = imgUrl;
      Rate = rate;
    }
  }
}