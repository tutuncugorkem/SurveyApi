using SurveyApi.Core.DTOs;
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

        Task<List<Survey>> GetSurveyDetailsById(int id);

        Task<List<Survey>> UpdateSurveyDetailsById(SurveyDetailDto entity, int id);


    }
}
