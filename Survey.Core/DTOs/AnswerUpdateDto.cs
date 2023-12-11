using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Core.DTOs
{
    public class AnswerUpdateDto
    {
        public string Text { get; set; }

        public int QuestionId { get; set; }

        public int Id { get; set; }

        public bool IsDeleted { get; set; }


    }
}
