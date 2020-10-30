namespace Pegusus.Data.Model.DBContext
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    public class PegususContext:DbContext
    {
        public PegususContext(DbContextOptions options) : base(options)
        {

        }
        DbSet<User> Users { get; set; }
        DbSet<Question> Questions { get; set; }
        DbSet<Answer> Answers { get; set; }
        DbSet<Post> Posts { get; set; }


}
}
