using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Core.Models
{
    public class Question : BaseEntity
    {

        public string Title { get; set; }
        public int SortOrder { get; set; }
        public int SurveyId { get; set; }

        public Survey Survey { get; set; }
        public Answer Answer { get; set; }

    }
}
