namespace Pegusus.Data.Model
{
    using System.Collections.Generic;
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}