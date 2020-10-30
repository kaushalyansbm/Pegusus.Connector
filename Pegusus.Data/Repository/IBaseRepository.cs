using NLog.Filters;
using Pegusus.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pegusus.Data.Repository
{
    public interface IBaseRepository<T> where T: class,IBaseEntity
    {
        Task<List<T>> getAll();
    }
}