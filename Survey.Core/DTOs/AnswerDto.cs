using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Core.DTOs
{
    public class AnswerDto : BaseDto
    {
        public int QuestionId { get; set; }
        public string Text { get; set; }
    }
}
