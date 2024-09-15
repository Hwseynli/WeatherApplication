using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using WeatherApplication.Business.Abstracts;
using WeatherApplication.Entities.Concrete.TableModels.ModelXml;

namespace WeatherApplication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherReportXmlController : ControllerBase
    {
        private readonly IWeatherReportXmlService _weatherReportXmlService;

        public WeatherReportXmlController(IWeatherReportXmlService weatherReportXmlService)
        {
            _weatherReportXmlService = weatherReportXmlService;
        }

        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    var result = _weatherReportXmlService.GetAllWeatherReports();
        //    if (result.IsSuccess)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
        [HttpGet("all")]
        public IActionResult GetAllWeatherReports()
        {
            var result =  _weatherReportXmlService.GetAllWeatherReports();
            if (result.IsSuccess)
            {
                var xmlSerializer = new XmlSerializer(typeof(List<WeatherReportXml>));
                using var stringWriter = new StringWriter();
                xmlSerializer.Serialize(stringWriter, result.Data);
                var xmlString = stringWriter.ToString();
                return Content(xmlString, "application/xml");
            }
            return NotFound(result.Message);
        }

        [HttpGet("{id}")]
        public IActionResult GetWeatherReportById(int id)
        {
            var result = _weatherReportXmlService.GetWeatherReportById(id);
            if (result.IsSuccess)
            {
                var xmlSerializer = new XmlSerializer(typeof(WeatherReportXml));
                using var stringWriter = new StringWriter();
                xmlSerializer.Serialize(stringWriter, result.Data);
                var xmlString = stringWriter.ToString();
                return Content(xmlString, "application/xml");
            }
            return NotFound(result.Message);
        }

        [HttpDelete]
        public IActionResult SoftDelete(int id)
        {
            var result = _weatherReportXmlService.SoftDeleteWeatherReport(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("HardDelete")]
        public IActionResult HardDeleteDistrict(int id)
        {
            var result = _weatherReportXmlService.HardDeleteWeatherReport(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
