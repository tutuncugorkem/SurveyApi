using AutoMapper;
using SurveyApi.Core.DTOs;
using SurveyApi.Core.Models;
using SurveyApi.Core.Repositories;
using SurveyApi.Core.Services;
using SurveyApi.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Service.Services
{
    public class SurveyService : Service<Survey>, ISurveyService
    {

        private readonly ISurveyRepository _surveyRepository;
        private readonly IMapper _mapper;

        public SurveyService(IUnitOfWork unitOfWork, IGenericRepository<Survey> repository, IMapper mapper, ISurveyRepository surveyRepository) : base(unitOfWork, repository)
        {
            _mapper = mapper;
            _surveyRepository = surveyRepository;
        }

        public async Task<CustomResponseDto<List<SurveyDetailDto>>> GetSurveyDetails()
        {
            var surveys = await _surveyRepository.GetSurveyDetails();
            var surveysDto = _mapper.Map<List<SurveyDetailDto>>(surveys);
            return CustomResponseDto<List<SurveyDetailDto>>.Success(200, surveysDto);
        }
    }
}
