using System.Linq.Expressions;
using WeatherApplication.Core.Entities.Concrete;

namespace WeatherApplication.Core.DataAccess.Abstract;
public interface IBaseInterface<T> where T : BaseEntity, new()
{
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    T GetById(int id);
    List<T> GetAll(Expression<Func<T, bool>>? filter = null);
}