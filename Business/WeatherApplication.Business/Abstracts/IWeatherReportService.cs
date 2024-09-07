using System;
using WeatherApplication.Core.Results.Abstract;
using WeatherApplication.Entities.Concrete.DTOs;

namespace WeatherApplication.Business.Abstracts
{
    public interface IWeatherReportService
    {
        IDataResult<IEnumerable<WeatherReportDto>> GetAllAsync();
        IDataResult<WeatherReportDto> GetByIdAsync(int id);
        IResult CreateAsync(WeatherReportDto weatherReport);
        IResult UpdateAsync(WeatherReportDto weatherReport);
        IResult DeleteAsync(int id);
    }
}

