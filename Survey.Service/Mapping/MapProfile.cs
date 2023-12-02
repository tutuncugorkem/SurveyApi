using AutoMapper;
using SurveyApi.Core.DTOs;
using SurveyApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Survey, SurveyDto>().ReverseMap();
            CreateMap<Question, QuestionDto>().ReverseMap();
            CreateMap<Answer, AnswerDto>().ReverseMap();
            CreateMap<SurveyUpdateDto, Survey>();
            CreateMap<Survey, SurveyDetailDto>(); //survey', surveydto ya cevır
        }
    }
}
