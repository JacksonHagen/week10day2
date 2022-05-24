using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using week10day2.FakeDb;
using week10day2.Models;

namespace week10day2.Services
{
  public class JobsService
  {
    internal List<Job> Get()
    {
      return Database.Jobs;
    }

    internal Job Get(string id)
    {
      Job job = Database.Jobs.Find(j => j.Id == id);
      if (job == null)
      {
        throw new Exception("Invalid Job ID");
      }
      return job;
    }
    internal Job Create(Job jobData)
    {
      Database.Jobs.Add(jobData);
      return jobData;
    }

    internal Job Edit(Job jobData)
    {
      Job original = Get(jobData.Id);
      original.Title = jobData.Title ?? original.Title;
      original.Description = jobData.Description ?? original.Description;
      original.ImgUrl = jobData.ImgUrl ?? original.ImgUrl;
      original.Rate = jobData.Rate;
      return original;
    }
    internal void Delete(string id)
    {
      Job job = Get(id);
      Database.Jobs.Remove(job);
    }
  }
}