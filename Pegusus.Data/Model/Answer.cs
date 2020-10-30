namespace Pegusus.Data.Model
{
    public class Answer: BaseEntity
    {
        public string Answers { get; set; }
        public int QuestionId { get; set; }
        public virtual Question Questions { get; set; }
    }
}
