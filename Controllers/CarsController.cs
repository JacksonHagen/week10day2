using Microsoft.AspNetCore.Mvc;
using week10day2.Models;
using week10day2.Services;

namespace week10day2.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CarsController : ControllerBase
  {
    private readonly CarsService _cs;
    public CarsController(CarsService cs)
    {
      _cs = cs;
    }

    [HttpGet]
    public ActionResult<List<Car>> Get()
    {
      try
      {
        List<Car> cars = _cs.Get();
        return Ok(cars);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Car> Get(string id)
    {
      try
      {
        Car car = _cs.Get(id);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car carData)
    {
      try
      {
        Car newCar = _cs.Create(carData);
        return Ok(newCar);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Car> Edit([FromBody] Car carData, string id)
    {
      try
      {
        carData.Id = id;
        Car updatedCar = _cs.Edit(carData);
        return Ok();
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<String> Delete(string id)
    {
      try
      {
        _cs.Delete(id);
        return Ok("Deletion successful!");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}