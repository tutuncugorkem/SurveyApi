﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Core
{
    public class Survey:BaseEntity
    {
        public string Name { get; set; }
        public List<Question> Questions { get; set; }
    }
}
