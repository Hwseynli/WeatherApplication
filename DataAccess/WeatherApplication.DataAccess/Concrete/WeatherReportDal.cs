using System;
using WeatherApplication.Core.DataAccess.Concrete;
using WeatherApplication.DataAccess.Abstract;
using WeatherApplication.DataAccess.Context;
using WeatherApplication.Entities.Concrete.TableModels;

namespace WeatherApplication.DataAccess.Concrete
{
    public class WeatherReportDal:BaseRepository<WeatherReport, AppDbContext>, IWeatherReportDal
    {
    }
}

