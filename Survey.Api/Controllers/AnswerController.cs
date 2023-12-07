using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyApi.Core.DTOs;
using SurveyApi.Core.Models;
using SurveyApi.Core.Services;

namespace SurveyApi.Api.Controllers
{
   
    public class AnswerController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Answer> _service;

        public AnswerController(IMapper mapper, IService<Answer> service)
        {

            _mapper = mapper;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAnswers()
        {
            var answers = await _service.GetAllAsync();
            var answersDto = _mapper.Map<List<AnswerDto>>(answers.ToList());
            return CreateActionResult(CustomResponseDto<List<AnswerDto>>.Success(200, answersDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAnswersById(int id)
        {
            var answer = await _service.GetByIdAsync(id);
            var answerDto = _mapper.Map<AnswerDto>(answer);
            return CreateActionResult(CustomResponseDto<AnswerDto>.Success(200, answerDto));
        }

        [HttpPost]
        public async Task<IActionResult> AddAnswer(AnswerDtoWOid answerDto)
        {
            var answer = await _service.AddAsync(_mapper.Map<Answer>(answerDto));
            var answersDto = _mapper.Map<AnswerDtoWOid>(answer);
            return CreateActionResult(CustomResponseDto<AnswerDtoWOid>.Success(201, answersDto));
        }


        [HttpPut]
        public async Task<IActionResult> UpdateAnswer(AnswerUpdateDto answerUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<Answer>(answerUpdateDto));

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnswer(int id)
        {
            var answer = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(answer);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }
    }
}
