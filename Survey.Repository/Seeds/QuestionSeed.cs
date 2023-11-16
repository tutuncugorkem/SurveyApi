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
    internal class QuestionSeed : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {

            builder.HasData(new Question
            {
                Id = 1,
                SurveyId = 1,
                SortOrder = 1,
                Title = "Memnun kaldınız mı?",
                IsActive = true,
                CreatedDate = DateTime.Now
            },
            new Question
            {
                Id = 2,
                SurveyId = 2,
                SortOrder = 1,
                Title = "Bizi tavsiye eder misiniz?",
                IsActive = true,
                CreatedDate = DateTime.Now
            });
        }
    }
}
