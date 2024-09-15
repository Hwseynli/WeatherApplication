using WeatherApplication.Core.Results.Abstract;
using WeatherApplication.Entities.Concrete.DTOs;
using WeatherApplication.Entities.Concrete.TableModels;

namespace WeatherApplication.Business.Abstracts;
public interface IDistrictService
{
    IDataResult<List<DistrictDto>> GetAll();
    IDataResult<District> GetById(int id);
    IResult Create(DistrictDto district);
    IResult Update(DistrictUpdateDto district);
    IResult SoftDelete(int id);
    IResult HardDelete(int id);
}

