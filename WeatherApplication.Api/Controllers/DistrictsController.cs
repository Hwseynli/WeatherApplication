using Microsoft.AspNetCore.Mvc;
using WeatherApplication.Business.Abstracts;
using WeatherApplication.Entities.Concrete.DTOs;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WeatherApplication.Api.Controllers;
[ApiController]
[Route("api/[controller]")]
public class DistrictsController : ControllerBase
{
    private readonly IDistrictService _districtService;

    public DistrictsController(IDistrictService districtService)
    {
        _districtService = districtService;
    }

    [HttpGet]
    public IActionResult GetDistrict()
    {
        var result = _districtService.GetAll();
        if (result.IsSuccess)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost]
    public IActionResult CreateDistrict(DistrictDto districtDto)
    {
        var result = _districtService.Create(districtDto);
        if (result.IsSuccess)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPut]
    public IActionResult UpdateDistrict(DistrictUpdateDto updateDto)
    {

        var result = _districtService.Update(updateDto);
        if (result.IsSuccess)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete("HardDelete")]
    public IActionResult HardDeleteDistrict(int id)
    {
        var result = _districtService.HardDelete(id);
        if (result.IsSuccess)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete("SoftDelete")]
    public IActionResult SoftDelete(int id)
    {
        var result = _districtService.SoftDelete(id);
        if (result.IsSuccess)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
   

}