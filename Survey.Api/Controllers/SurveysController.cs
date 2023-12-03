using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyApi.Core.DTOs;
using SurveyApi.Core.Models;
using SurveyApi.Core.Services;
using SurveyApi.Service.Mapping;
using SurveyApi.Service.Services;

namespace SurveyApi.Api.Controllers
{

    public class SurveysController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ISurveyService _service;
        
        public SurveysController(IMapper mapper, ISurveyService service)
        {
            _mapper = mapper;
            _service = service;
            
        }

        //karışmasın get'ler diye;
        //GET api/surveys/getsurveydetails
        [HttpGet("[action]")]
        public async Task<IActionResult> GetSurveyDetail()
        {
            return CreateActionResult(await _service.GetSurveyDetails());
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var surveys = await _service.GetAllAsync();
            var surveysDtos = _mapper.Map<List<SurveyDto>>(surveys.ToList());
            return CreateActionResult(CustomResponseDto<List<SurveyDto>>.Success(200, surveysDtos));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var survey = await _service.GetByIdAsync(id);
            var surveyDto = _mapper.Map<SurveyDto>(survey);
            return CreateActionResult(CustomResponseDto<SurveyDto>.Success(200, surveyDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(SurveyDto surveyDto)
        {
            var survey = await _service.AddAsync(_mapper.Map<Survey>(surveyDto));
            var surveysDto = _mapper.Map<SurveyDto>(survey);
            return CreateActionResult(CustomResponseDto<SurveyDto>.Success(201, surveyDto));

        }

        [HttpPut]
        public async Task<IActionResult> Update(SurveyUpdateDto surveyDto)
        {
            await _service.UpdateAsync(_mapper.Map<Survey>(surveyDto));
        
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var survey = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(survey);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
