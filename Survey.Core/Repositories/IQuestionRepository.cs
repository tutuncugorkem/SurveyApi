using SurveyApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Core.Repositories
{
    public interface IQuestionRepository : IGenericRepository<Question>
    {
        Task<List<Question>> GetQuestionDetails();

        Task<List<Question>> GetQuestionDetailById(int id);

    }
}
