using AutoMapper;
using SurveyApi.Core.DTOs;
using SurveyApi.Core.Models;
using SurveyApi.Core.Repositories;
using SurveyApi.Core.Services;
using SurveyApi.Core.UnitOfWorks;
using SurveyApi.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Service.Services
{
    public class QuestionService : Service<Question>, IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public QuestionService(IUnitOfWork unitOfWork, IGenericRepository<Question> repository, IMapper mapper, IQuestionRepository questionRepository) : base(unitOfWork, repository)
        {
            _mapper = mapper;
            _questionRepository = questionRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<CustomResponseDto<List<QuestionDetailDto>>> GetQuestionDetailById(int id)
        {
            var questionId = await _questionRepository.GetQuestionDetailById(id);
            var questionIdDto = _mapper.Map<List<QuestionDetailDto>>(questionId);
            return CustomResponseDto<List<QuestionDetailDto>>.Success(200, questionIdDto);
        }

        public async Task<CustomResponseDto<List<QuestionDetailDto>>> GetQuestionDetails()
        {
            var question = await _questionRepository.GetQuestionDetails();
            var questionDto = _mapper.Map<List<QuestionDetailDto>>(question);
            return CustomResponseDto<List<QuestionDetailDto>>.Success(200, questionDto);
        }
    }
}
