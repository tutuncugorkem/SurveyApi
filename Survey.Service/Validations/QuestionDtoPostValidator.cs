using FluentValidation;
using SurveyApi.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Service.Validations
{
    public class QuestionDtoPostValidator : AbstractValidator<QuestionDtoWOid>
    {
        public QuestionDtoPostValidator()
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("{PropertyName} is required").NotNull().WithMessage("{PropertyName} is required");
            RuleFor(x => x.SurveyId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater than 0");
            RuleFor(x => x.SortOrder).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater than 0");

        }
    }
}
