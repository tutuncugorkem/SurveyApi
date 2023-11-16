using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Core.Services
{
    public interface IService<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync(); //igenericrepository ile farklılık olsun diye örnek olması açısından yaptık burayı
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<T> AddAsync(T entity);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);  //Iservicede bu değişiklikleri yansıtacağımız için void değil, artık burada TASK tipinde olmalı update remove ve removerange
        Task RemoveAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entities);

    }
}
