namespace Pegusus.Data.Model
{
    public class Question : BaseEntity
    {
        public string Questions { get; set; }
        public int PostId { get; set; }
        public virtual Post Posts { get; set; }
    }
}