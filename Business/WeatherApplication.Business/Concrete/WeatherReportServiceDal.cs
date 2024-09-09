using WeatherApplication.Business.Abstracts;
using WeatherApplication.Business.BaseMessages;
using WeatherApplication.Core.Results.Abstract;
using WeatherApplication.Core.Results.Concrete;
using WeatherApplication.DataAccess.Abstract;
using WeatherApplication.Entities.Concrete.DTOs;
using WeatherApplication.Entities.Concrete.TableModels;

namespace WeatherApplication.Business.Concrete
{
    public class WeatherReportServiceDal : IWeatherReportService
    {
        private readonly IWeatherReportDal _weatherReportDal;
        public WeatherReportServiceDal(IWeatherReportDal weatherReportDal)
        {
            _weatherReportDal = weatherReportDal;
        }

        public IResult SoftDelete(int id)
        {
            var model = GetByIdAsync(id).Data;
            model.IsDeleted = id;
            _weatherReportDal.UpdateAsync(model);
            return new SuccessResult(UIMessage.DELETED_MESSAGE);
        }

        public IResult HardDelete(int id)
        {
            var model = GetByIdAsync(id).Data;
            _weatherReportDal.DeleteAsync(model);
            return new SuccessResult(UIMessage.HARD_DELETED_MESSAGE);
        }

        public IDataResult<List<WeatherReportDto>> GetAllAsync()
        {
            var result = _weatherReportDal.GetAllAsync(x => x.IsDeleted == 0);
            List<WeatherReportDto> dtos = new List<WeatherReportDto>();
            foreach (var item in result)
            {
                WeatherReportDto dto = new WeatherReportDto()
                {
                    Id = item.Id,
                    WeatherId = item.WeatherId,
                    Clouds = item.Clouds,
                    FeelsLike = item.FeelsLike,
                    DateTime = item.DateTime,
                    Description = item.Description,
                    GroundLevel = item.GroundLevel,
                    Humidity = item.Humidity,
                    DistrictId = item.DistrictId,
                    Icon = item.Icon,
                    Main = item.Main,
                    Pressure = item.Pressure,
                    SeaLevel = item.SeaLevel,
                    WindDegree = item.WindDegree,
                    Temp = item.Temp,
                    TempMax = item.TempMax,
                    TempMin = item.TempMin,
                    WindGust = item.WindGust,
                    WindSpeed = item.WindSpeed,
                    WeatherDiscritName = item.District.Title,
                };
                dtos.Add(dto);
            }
            return new SuccessDataResult<List<WeatherReportDto>>(dtos);
        }

        public IDataResult<WeatherReport> GetByIdAsync(int id)
        {
            var result = _weatherReportDal.GetById(id);
            return new SuccessDataResult<WeatherReport>(result);
        }


    }
}

