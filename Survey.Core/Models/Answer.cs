using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Core.Models
{
    public class Answer : BaseEntity
    {
        
        public string Text { get; set; }

        public Question Question { get; set; }


        public int QuestionId { get; set; }




    }
}
