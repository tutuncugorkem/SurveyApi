using FluentValidation;
using SurveyApi.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Service.Validations
{
    public class SurveyDtoPostValidator : AbstractValidator<SurveyDtoWOid>
    {
        public SurveyDtoPostValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("{PropertyName} is required").NotNull().WithMessage("{PropertyName} is required");
            
        }
    }
}
