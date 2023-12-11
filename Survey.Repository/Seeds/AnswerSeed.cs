using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SurveyApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Repository.Seeds
{
    internal class AnswerSeed : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasData(new Answer
            {
                Id = 1,
                QuestionId = 1,
                Text = "Evet",
                IsDeleted = false,
                CreatedDate = DateTime.Now
            },
            new Answer
            {
                Id = 2,
                QuestionId = 2,
                Text = "Ederim",
                IsDeleted = false,
                CreatedDate = DateTime.Now
            });
        }
    }
}
