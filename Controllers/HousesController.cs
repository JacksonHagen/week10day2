using Microsoft.AspNetCore.Mvc;
using week10day2.Models;
using week10day2.Services;

namespace week10day2.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class HousesController : ControllerBase
  {
    private readonly HousesService _hs;

    public HousesController(HousesService hs)
    {
      _hs = hs;
    }

    [HttpGet]
    public ActionResult<List<House>> Get()
    {
      try
      {
        List<House> houses = _hs.Get();
        return Ok(houses);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<House> Get(string id)
    {
      try
      {
        House house = _hs.Get(id);
        return Ok(house);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<House> Create([FromBody] House houseData)
    {
      try
      {
        House house = _hs.Create(houseData);
        return Ok(house);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<House> Edit([FromBody] House houseData, string id)
    {
      try
      {
        houseData.Id = id;
        House house = _hs.Edit(houseData);
        return Ok(house);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<String> Delete(string id) {
      try
      {
        _hs.Delete(id);
        return Ok("Deletion Successful");
      }
      catch(Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}