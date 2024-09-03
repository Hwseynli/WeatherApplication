using System;
using System.Linq.Expressions;
using WeatherApplication.Core.Entities.Concrete;

namespace WeatherApplication.Core.DataAccess.Abstract;
public interface IBaseInterface<T> where T : BaseEntity, new()
{
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task<T> GetById(int id);
    Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null);
}