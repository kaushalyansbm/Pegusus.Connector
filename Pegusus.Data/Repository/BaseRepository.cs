namespace Pegusus.Data.Repository
{
    using Data.Model;
    using Data.Model.DBContext;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseEntity
    {
        private DbSet<T> _pegususContext { get; set; }
        private PegususContext _context { get; set; }

        public BaseRepository(DbSet<T> pegususContext)
        {
            _pegususContext = pegususContext;

        }
        public async Task<List<T>> getAllAsync()
        {
            try
            {
                return await _pegususContext.ToListAsync();
            }
            catch (Exception ex)
            {
                return new List<T>();
            }
        }

        public IQueryable<T> getAll()
        {
            return _pegususContext;
        }

        public async Task<bool> Commit(PegususContext context)
        {
            try
            {
                _context = context;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
