using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Core.Models
{
    public class Survey : BaseEntity
    {
        public string Name { get; set; }
        public Question Questions { get; set; }
    }
}
