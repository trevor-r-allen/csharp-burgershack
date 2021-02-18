using System.Collections.Generic;
using csharp_burgershack.Models;
using csharp_burgershack.Services;
using Microsoft.AspNetCore.Mvc;

namespace BurgersController
{
  [ApiController]
  [Route("api/[controller]")]
  public class BurgersController : ControllerBase
  {
    private readonly BurgersService _burgersService;
    public BurgersController(BurgersService burgersService)
    {
      _burgersService = burgersService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Burger>> Get()
    {
      try
      {
        return Ok(_burgersService.Get());
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }

    [HttpGet("{burgerId}")]
    public ActionResult<Burger> Get(int burgerId)
    {
      try
      {
        return Ok(_burgersService.Get(burgerId));
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<Burger> Create([FromBody] Burger newBurger)
    {
      try
      {
        return Ok(_burgersService.Create(newBurger));
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }

    [HttpPut("{burgerId}")]
    public ActionResult<Burger> Edit([FromBody] Burger editedBurger, int burgerId)
    {
      try
      {
        editedBurger.Id = burgerId;
        return Ok(_burgersService.Edit(editedBurger));
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }

    [HttpDelete("{burgerId}")]
    public ActionResult<string> Delete(int burgerId)
    {
      try
      {
        return Ok(_burgersService.Delete(burgerId));
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }
  }
}