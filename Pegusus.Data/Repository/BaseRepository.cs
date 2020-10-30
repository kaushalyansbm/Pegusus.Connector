using Pegusus.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pegusus.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseEntity
    {
        public Task<List<T>> getAll()
        {
            throw new NotImplementedException();
        }
    }
}
