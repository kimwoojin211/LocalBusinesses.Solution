using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalBusinesses.Models;

namespace LocalBusinesses.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BusinessesController : ControllerBase
  {
    private readonly LocalBusinessesContext _db;
    public BusinessesController(LocalBusinessesContext db)
    {
      _db = db;
    }
    // GET api/businesses
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Business>>> Get(string name, string category, string hoursOpen, string hoursClose,string page, string pageSize)
    {
      var query = _db.Businesses.AsQueryable();
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (category != null)
      {
        query = query.Where(entry => entry.Category == category);
      }
      // looking if shop is open at 8:00am (hoursopen), returns business if HoursOpen is before or at hoursopen (military time)
      if (hoursOpen != null)
      {
        System.Console.WriteLine($"hoursOpen = {hoursOpen}");
        foreach(Business business in query.ToList())
        {  
          System.Console.WriteLine($"entry.HoursOpen = {business.HoursOpen}");
        }
        query = query.Where(entry => String.Compare(entry.HoursOpen, hoursOpen)<=0);
      }
      // looking if shop is closed at 5:00pm (hoursclose), returns business if HoursClose is before or at hoursclose (military time)
      if (hoursClose != null)
      {
        query = query.Where(entry => String.Compare(entry.HoursClose, hoursClose) <= 0);
      }
      if (page != null)
      {
        int size = (pageSize == null ? 50 : Int32.Parse(pageSize));
        query = query.OrderBy(business => business.BusinessId).Skip((int.Parse(page) - 1) * size).Take(size);
      }

      return await query.ToListAsync();
    }

    // POST api/Businesses
    [HttpPost]
    public async Task<ActionResult<Business>> Post(Business business)
    {
      _db.Businesses.Add(business);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetBusiness), new { id = business.BusinessId }, business);
    }
    // GET: api/Businesses/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Business>> GetBusiness(int id)
    {
      var business = await _db.Businesses.FindAsync(id);

      if (business == null)
      {
        return NotFound();
      }

      return business;
    }

    // PUT: api/Businesses/{#}
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Business business)
    {
      if (id != business.BusinessId)
      {
        return BadRequest();
      }
      _db.Entry(business).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!BusinessExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }
    // DELETE: api/Businesses/1
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBusiness(int id)
    {
      var business = await _db.Businesses.FindAsync(id);
      if (business == null)
      {
        return NotFound();
      }
        _db.Businesses.Remove(business);
        await _db.SaveChangesAsync();
        return NoContent();
    }    
    private bool BusinessExists(int id)
    {
      return _db.Businesses.Any(e => e.BusinessId == id);
    }
  }
}