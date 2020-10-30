namespace Pegusus.Data.Model
{
    using System;
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string By { get; set; }
        public DateTime Date { get; set; }
        public int Description { get; set; }
        public int UserId { get; set; }
        public virtual User Users { get; set; }

    }
}