namespace Pegusus.Data.Repository
{
    using Data.Model;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IBaseRepository<T> where T: class,IBaseEntity
    {
        Task<List<T>> getAllAsync();
        IQueryable<T> getAll();
    }
}