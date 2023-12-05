using AutoMapper;
using SurveyApi.Core.DTOs;
using SurveyApi.Core.Models;
using SurveyApi.Core.Repositories;
using SurveyApi.Core.Services;
using SurveyApi.Core.UnitOfWorks;
using SurveyApi.Repository.UnitOfWorks;
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
        private readonly IUnitOfWork _unitOfWork;

        public SurveyService(IUnitOfWork unitOfWork, IGenericRepository<Survey> repository, IMapper mapper, ISurveyRepository surveyRepository) : base(unitOfWork, repository)
        {
            _mapper = mapper;
            _surveyRepository = surveyRepository;
            _unitOfWork = unitOfWork;

        }

        public async Task<CustomResponseDto<List<SurveyDetailDto>>> GetSurveyDetails()
        {
            var surveys = await _surveyRepository.GetSurveyDetails();
            var surveysDto = _mapper.Map<List<SurveyDetailDto>>(surveys);
            return CustomResponseDto<List<SurveyDetailDto>>.Success(200, surveysDto);
        }

        public async Task<CustomResponseDto<List<SurveyDetailDto>>> GetSurveyDetailsById(int id)
        {
            var survey = await _surveyRepository.GetSurveyDetailsById(id);
            var surveyDtoId = _mapper.Map<List<SurveyDetailDto>>(survey);
            return CustomResponseDto<List<SurveyDetailDto>>.Success(200, surveyDtoId);
        }

        public async Task<CustomResponseDto<List<SurveyDetailDto>>> UpdateSurveyDetailsById(SurveyDetailDto entity,int id)
        {
           //repository-uow-await service
           var survey= await _surveyRepository.UpdateSurveyDetailsById(entity,id);
            var surveyDto = _mapper.Map<List<SurveyDetailDto>>(survey);
            await _unitOfWork.CommitAsync();
           return CustomResponseDto<List<SurveyDetailDto>>.Success(200, surveyDto);


        }

    }
}
