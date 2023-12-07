using SurveyApi.Core.DTOs;
using SurveyApi.Core.Models;
using SurveyApi.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Core.Services
{
    public interface IQuestionService : IService<Question>
    {
        Task<CustomResponseDto<List<QuestionDetailDto>>> GetQuestionDetails();

        Task<CustomResponseDto<List<QuestionDetailDto>>> GetQuestionDetailById(int id);

    }
}
