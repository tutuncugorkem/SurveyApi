using SurveyApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Core.DTOs
{
    public class SurveyDto : BaseDto
    {
        public string Name { get; set; }
        public Question Questions { get; set; }

    }
}
