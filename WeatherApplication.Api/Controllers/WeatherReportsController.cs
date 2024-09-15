using Microsoft.AspNetCore.Mvc;
using WeatherApplication.Business.Abstracts;

namespace WeatherApplication.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherReportsController : ControllerBase
    {
        private readonly IWeatherReportService _weatherReportService;
        public WeatherReportsController(IWeatherReportService weatherReportService)
        {
            _weatherReportService = weatherReportService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _weatherReportService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var result = _weatherReportService.GetById(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete]
        public IActionResult SoftDelete(int id)
        {
            var result = _weatherReportService.SoftDelete(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("HardDelete")]
        public IActionResult HardDeleteDistrict(int id)
        {
            var result = _weatherReportService.HardDelete(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

