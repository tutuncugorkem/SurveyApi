using SurveyApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Core.Repositories
{
    public interface ISurveyRepository : IGenericRepository<Survey>
    {
        Task<List<Survey>> GetSurveyDetails();
    }
}
