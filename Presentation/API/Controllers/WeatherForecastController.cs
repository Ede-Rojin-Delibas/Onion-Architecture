using API.Modals;
using API.Repository;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpGet("KullanýcýlarýGetir")]
        public IActionResult KullanýcýlarýGetir()
        {
            User newObj = new User();
            newObj.Name = "Rojin";
            newObj.Surname = "Delibas";
            newObj.Age = 22;

            return Ok(newObj);

        }
        [HttpGet("Products")]
        public IActionResult Products()
        {
            productRepository Repo1 = new productRepository(); 
            var model = Repo1.GetAll();

            return Ok(model);  //ok sadece controller da
        }
        [HttpGet("KategoriListesi")]
        public IActionResult KategoriListesi(int KId)
        {
            productRepository productRepository = new productRepository();
            var model2 = productRepository.GetByKýd(KId);
            return Ok(model2);
            

        }
    }


}






