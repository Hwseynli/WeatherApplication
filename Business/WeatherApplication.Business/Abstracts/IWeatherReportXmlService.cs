using WeatherApplication.Core.Results.Abstract;
using WeatherApplication.Entities.Concrete.TableModels.ModelXml;

namespace WeatherApplication.Business.Abstracts;
public interface IWeatherReportXmlService
{
    IDataResult<List<WeatherReportXml>> GetAllWeatherReports();
    IDataResult<WeatherReportXml> GetWeatherReportById(int id);
    IResult SoftDeleteWeatherReport(int id);
    IResult HardDeleteWeatherReport(int id);
}
