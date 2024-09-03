using System;
using WeatherApplication.Entities.Concrete.DTOs;

namespace WeatherApplication.Business.Abstracts
{
    public interface IDistrictService
    {
        Task<IEnumerable<DistrictDto>> GetAllAsync();
        Task<DistrictDto> GetByIdAsync(int id);
        Task<DistrictDto> CreateAsync(DistrictDto district);
        Task UpdateAsync(DistrictDto district);
        Task DeleteAsync(int id);
    }
}

