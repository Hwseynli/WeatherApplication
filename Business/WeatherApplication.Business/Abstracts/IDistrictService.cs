using System;
using WeatherApplication.Core.Results.Abstract;
using WeatherApplication.Entities.Concrete.DTOs;
using WeatherApplication.Entities.Concrete.TableModels;

namespace WeatherApplication.Business.Abstracts
{
    public interface IDistrictService
    {
        IDataResult<List<DistrictDto>> GetAllAsync();
        IDataResult<District> GetByIdAsync(int id);
        IResult CreateAsync(DistrictDto district);
        IResult UpdateAsync(DistrictDto district);
        IResult DeleteAsync(int id);
    }
}

