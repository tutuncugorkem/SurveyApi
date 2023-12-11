namespace SurveyApi.Core.Models
{
    public class Answer : BaseEntity
    {
        public string Text { get; set; }
        public Question Question { get; set; }
        public int QuestionId { get; set; }
    }
}
