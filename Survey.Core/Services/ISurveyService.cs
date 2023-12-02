using SurveyApi.Core.DTOs;
using SurveyApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Core.Services
{
    public interface ISurveyService : IService<Survey>
    {
        Task<CustomResponseDto<List<SurveyDetailDto>>> GetSurveyDetails();

    }
}
