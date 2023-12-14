using FluentValidation;
using SurveyApi.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Service.Validations
{
    public class AnswerDtoPostValidator : AbstractValidator<AnswerDtoWOid>
    {
        public AnswerDtoPostValidator()
        {
            RuleFor(x => x.Text).NotEmpty().WithMessage("{PropertyName} is required").NotNull().WithMessage("{PropertyName} is required");
            RuleFor(x => x.QuestionId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater than 0");
        }
    }
}
