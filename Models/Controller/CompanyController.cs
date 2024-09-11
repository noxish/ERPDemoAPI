using ERPDemoAPI.Models;
using ERPDemoAPI.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERPDemoAPI;
[Route("/[controller]")]
[ApiController]
public class CompanyController : ControllerBase
{
    private readonly ERPDemoAPIContext _context;

    public CompanyController(ERPDemoAPIContext context)
    {
        _context = context; 
    }

    // GET: api/<ValuesController>
    [HttpGet]
    public List<Company> Get()
    {
        return _context.Companies.OrderBy(n => n.Id).AsNoTracking().ToList();
    }

    // GET api/<ValuesController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // GET api/<ValuesController>/5
    [HttpGet("ByCompanyName/{name}")]
    public List<Company> SearchByName(string name)
    {
        return _context.Companies.Where(n => n.CompanyName.Contains(name)).OrderBy(n => n.Id).AsNoTracking().ToList();
    }

    // GET api/<ValuesController>/city/5
    [HttpGet("ByCity/{city}")]
    public List<Company> GetCompaniesByCity(string city)
    {
        return _context.Companies.Where(n => n.City == city).OrderBy(n => n.Id).AsNoTracking().ToList();
    }

    // GET api/<ValuesController>/city/5
    [HttpGet("ByCountry/{country}")]
    public List<Company> GetCompaniesByCountry(string country)
    {
        return _context.Companies.Where(n => n.Country == country).OrderBy(n => n.Id).AsNoTracking().ToList();
    }

    // GET api/<ValuesController>/city/5
    [HttpGet("ByCountryCode/{countryCode}")]
    public List<Company> GetCompaniesByCountryCode(string countryCode)
    {
        return _context.Companies.Where(n => n.CountryCode == countryCode).OrderBy(n => n.Id).AsNoTracking().ToList();
    }

    //// POST api/<ValuesController>
    //[HttpPost]
    //public void Post([FromBody] string value)
    //{
    //}

    //// PUT api/<ValuesController>/5
    //[HttpPut("{id}")]
    //public void Put(int id, [FromBody] string value)
    //{
    //}

    //// DELETE api/<ValuesController>/5
    //[HttpDelete("{id}")]
    //public void Delete(int id)
    //{
    //}
}
