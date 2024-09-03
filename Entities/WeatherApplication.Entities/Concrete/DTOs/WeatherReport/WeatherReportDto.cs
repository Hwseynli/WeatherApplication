using System;
using WeatherApplication.Entities.Concrete.TableModels;

namespace WeatherApplication.Entities.Concrete.DTOs;
public class WeatherReportDto
{
    public int Id { get; set; }
    public int WeatherId { get; set; }
    public string Main { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }
    public float Temp { get; set; }
    public float FeelsLike { get; set; }
    public float TempMin { get; set; }
    public float TempMax { get; set; }
    public float Pressure { get; set; }
    public float Humidity { get; set; }
    public float SeaLevel { get; set; }
    public float GroundLevel { get; set; }
    public float WindSpeed { get; set; }
    public float WindDegree { get; set; }
    public float WindGust { get; set; }
    public float Clouds { get; set; }
    public DateTime DateTime { get; set; }
    public int DistrictId { get; set; }

    public static List<WeatherReportDto> AtWeatherReportDto(WeatherReport weatherReport)
    {
        WeatherReportDto weatherReportDto = new()
        {
            Id = weatherReport.Id,
            WeatherId=weatherReport.WeatherId,
            Main=weatherReport.Main,
            Description=weatherReport.Description,
            Icon=weatherReport.Icon,
            Temp=weatherReport.Temp,
            FeelsLike=weatherReport.FeelsLike,
            TempMin=weatherReport.TempMin,
            TempMax=weatherReport.TempMax,
            Pressure=weatherReport.Pressure,
            Humidity=weatherReport.Humidity,
            SeaLevel=weatherReport.SeaLevel,
            GroundLevel=weatherReport.GroundLevel,
            WindDegree=weatherReport.WindDegree,
            WindGust=weatherReport.WindGust,
            Clouds=weatherReport.Clouds,
            DateTime=weatherReport.DateTime,
            DistrictId=weatherReport.DistrictId,
            WindSpeed=weatherReport.WindSpeed
        };
        List<WeatherReportDto> weatherReportDtos = new List<WeatherReportDto>();
        weatherReportDtos.Add(weatherReportDto);
        return weatherReportDtos;
    }

}

