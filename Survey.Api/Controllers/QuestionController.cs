using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyApi.Core.DTOs;
using SurveyApi.Core.Models;
using SurveyApi.Core.Services;
using SurveyApi.Service.Services;
using System.Runtime.CompilerServices;

namespace SurveyApi.Api.Controllers
{

    public class QuestionController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IQuestionService _service;

        public QuestionController(IQuestionService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetQuestionDetail()
        {
            return CreateActionResult(await _service.GetQuestionDetails());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuestionDetailsById(int id)
        {
            return CreateActionResult(await _service.GetQuestionDetailById(id));
        }


        [HttpPost]
        public async Task<IActionResult> AddQuestion(QuestionDtoWOid questionDto)
        {
            var question = await _service.AddAsync(_mapper.Map<Question>(questionDto));
            var questionsDto = _mapper.Map<QuestionDtoWOid>(question);
            return CreateActionResult(CustomResponseDto<QuestionDtoWOid>.Success(201, questionsDto));
        }
        

        [HttpPut]
        public async Task<IActionResult> UpdateQuestion(QuestionUpdateDto questionUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<Question>(questionUpdateDto));

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuestion(int id)
        {
            var question = await _service.GetByIdAsync(id);
            question.IsDeleted = true;
            await _service.RemoveAsync(question);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }
    }
}
