using System;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WeatherApplication.Business.Abstracts;
using WeatherApplication.Business.BaseMessages;
using WeatherApplication.Core.Results.Abstract;
using WeatherApplication.Core.Results.Concrete;
using WeatherApplication.DataAccess.Abstract;
using WeatherApplication.DataAccess.Context;
using WeatherApplication.Entities.Concrete.DTOs;
using WeatherApplication.Entities.Concrete.TableModels;

namespace WeatherApplication.Business.Concrete
{
    public class DiscritServiceDal : IDistrictService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IDistrictDal _districtDal;
        public DiscritServiceDal(IMapper mapper,AppDbContext context, IDistrictDal districtDal)
        {
            _context = context;
            _mapper = mapper;
            _districtDal = districtDal;
        }

        public IResult CreateAsync(DistrictDto dto)
        {
            var model = DistrictDto.ToDiscritDtos(dto);
            _districtDal.AddAsync(model);
            return new SuccessResult(UIMessage.ADD_MESSAGE);
        }

        public IResult DeleteAsync(int id)
        {
            var model = GetByIdAsync(id).Data;
            model.IsDeleted = id;
            _districtDal.UpdateAsync(model);
            return new SuccessResult(UIMessage.DELETED_MESSAGE);
        }

        public IDataResult<List<DistrictDto>> GetAllAsync()
        {
            var models = _districtDal.GetAllAsync(x => x.IsDeleted == 0);
            List<DistrictDto> dtos = new List<DistrictDto>();
            foreach (var item in models)
            {
                DistrictDto districtDto = new DistrictDto()
                {
                    Id = item.Id,
                    Latitude = item.Latitude,

                };

            }
        }

        public IDataResult<District> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IResult UpdateAsync(DistrictDto district)
        {
            throw new NotImplementedException();
        }
    }
}

