using WeatherApplication.Business.Abstracts;
using WeatherApplication.Business.BaseMessages;
using WeatherApplication.Core.Results.Abstract;
using WeatherApplication.Core.Results.Concrete;
using WeatherApplication.DataAccess.Abstract;
using WeatherApplication.DataAccess.Context;
using WeatherApplication.Entities.Concrete.DTOs;
using WeatherApplication.Entities.Concrete.TableModels;

namespace WeatherApplication.Business.Concrete;
public class DistrictServiceDal : IDistrictService
{
    private readonly AppDbContext _context;
    private readonly IDistrictDal _districtDal;
    public DistrictServiceDal(AppDbContext context, IDistrictDal districtDal)
    {
        _context = context;
        _districtDal = districtDal;
    }

    public IResult Create(DistrictDto dto)
    {
        var model = DistrictDto.ToDiscritDtos(dto);
        _districtDal.Add(model);
        return new SuccessResult(UIMessage.ADD_MESSAGE);
    }

    public IResult SoftDelete(int id)
    {
        var model = GetById(id).Data;
        model.IsDeleted = id;
        _districtDal.Update(model);
        return new SuccessResult(UIMessage.DELETED_MESSAGE);
    }

    public IResult HardDelete(int id)
    {
        var model = GetById(id).Data;
        _districtDal.Delete(model);
        return new SuccessResult(UIMessage.HARD_DELETED_MESSAGE);
    }

    public IDataResult<List<DistrictDto>> GetAll()
    {
        var models = _districtDal.GetAll(x => x.IsDeleted == 0);
        List<DistrictDto> dtos = new List<DistrictDto>();
        foreach (var item in models)
        {
            DistrictDto districtDto = new DistrictDto()
            {
                Id = item.Id,
                Latitude = item.Latitude,
                Longitude=item.Longitude,
                Title=item.Title
            };
            dtos.Add(districtDto);
        }
        return new SuccessDataResult<List<DistrictDto>>(dtos);
    }

    public IDataResult<District> GetById(int id)
    {
        var model = _districtDal.GetById(id);
        return new SuccessDataResult<District>(model);
    }

    public IResult Update(DistrictUpdateDto district)
    {
        var model = DistrictUpdateDto.ToDistrict(district);
        var value = GetById(district.Id).Data;
        model.UpdateDate = DateTime.Now;
        _districtDal.Update(model);
        return new SuccessResult(UIMessage.UPDATE_MESSAGE);

    }
}

