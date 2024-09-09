using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        var result = _districtService.GetAllAsync();
        if (result.IsSuccess)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost]
    public IActionResult CreateDistrict(DistrictDto districtDto)
    {
        var result = _districtService.CreateAsync(districtDto);
        if (result.IsSuccess)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPut]
    public IActionResult UpdateDistrict(DistrictUpdateDto updateDto)
    {

        var result = _districtService.UpdateAsync(updateDto);
        if (result.IsSuccess)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete]
    public IActionResult DeleteDistrict(DistrictDto dto)
    {
        var result = _districtService.DeleteAsync(dto.Id);
        if (result.IsSuccess)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}