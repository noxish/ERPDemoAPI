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
    /// <summary>
    /// Get all companies
    /// </summary>
    [HttpGet]
    public List<Company> Get()
    {
        return _context.Companies.OrderBy(n => n.Id).AsNoTracking().ToList();
    }

    // GET api/<ValuesController>/ByCompanyName/Firma Industries 758
    /// <summary>
    /// Find Company by Name
    /// </summary>
    [HttpGet("ByCompanyName/{name}")]
    public List<Company> SearchByName(string name)
    {
        return _context.Companies.Where(n => n.CompanyName.Contains(name)).OrderBy(n => n.Id).AsNoTracking().ToList();
    }
    // GET api/<ValuesController>/ByPhone/+43 747-6356
    /// <summary>
    /// Get Companies by Phone Number
    /// </summary>
    [HttpGet("ByPhone/{country}")]
    public List<Company> GetCompaniesByPhone(string phone)
    {
        return _context.Companies.Where(n => n.Telephone == phone).OrderBy(n => n.Id).AsNoTracking().ToList();
    }
    // GET api/<ValuesController>/city/Vienna
    /// <summary>
    /// Get Companies by City Name
    /// </summary>
    [HttpGet("ByCity/{city}")]
    public List<Company> GetCompaniesByCity(string city)
    {
        return _context.Companies.Where(n => n.City == city).OrderBy(n => n.Id).AsNoTracking().ToList();
    }

    // GET api/<ValuesController>/ByPostalCode/1010
    /// <summary>
    /// Get Companies by PostalCode
    /// </summary>
    [HttpGet("ByPostalCode/{postalcode}")]
    public List<Company> GetCompaniesByPostalCode(int postalcode)
    {
        return _context.Companies.Where(n => n.PostalCode == postalcode).OrderBy(n => n.Id).AsNoTracking().ToList();
    }

    // GET api/<ValuesController>/ByCountry/Austria
    /// <summary>
    /// Get Companies by Country Name in German
    /// </summary>
    [HttpGet("ByCountry/{country}")]
    public List<Company> GetCompaniesByCountry(string country)
    {
        return _context.Companies.Where(n => n.Country == country).OrderBy(n => n.Id).AsNoTracking().ToList();
    }

    // GET api/<ValuesController>/ByCountryCode/AT
    /// <summary>
    /// Get Companies by Country ISO 3166-1 A-2 Code
    /// </summary>
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
