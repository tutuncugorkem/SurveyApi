using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Core.DTOs
{
    public class SurveyUpdateDto
    {
        //update ozelınde ornek olması ıcın
        public string Name { get; set; }

        public int Id { get; set; }

        
        public DateTime? UpdatedDate { get; set; }  

        public bool IsActive { get; set; }
    }
}
