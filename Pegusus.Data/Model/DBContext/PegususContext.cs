namespace Pegusus.Data.Model.DBContext
{
    using Microsoft.EntityFrameworkCore;
    public class PegususContext:DbContext
    {
        public PegususContext(DbContextOptions options) : base(options)
        {

        }
    }
}
