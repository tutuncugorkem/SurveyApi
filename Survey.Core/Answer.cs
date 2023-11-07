using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Core
{
    public class Answer:BaseEntity
    {
        public int QuestionId { get; set; }
        public string Text { get; set; }

        public Question Question { get; set; }
    }
}
