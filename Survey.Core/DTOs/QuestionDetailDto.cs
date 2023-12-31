﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Core.DTOs
{
    public class QuestionDetailDto : BaseDto
    {
        public string Title { get; set; }
        public int SortOrder { get; set; }
        public int SurveyId { get; set; }

        public AnswerDto Answer { get; set; }
    }
}
