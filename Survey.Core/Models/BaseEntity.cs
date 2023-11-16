using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Core.Models
{
    //abstract olma nedeni baseentityden nesne örneği alamayalım diye
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }   //ilk data eklenirken null geleceği için nullable yaptık

        public bool IsActive { get; set; }

    }
}
