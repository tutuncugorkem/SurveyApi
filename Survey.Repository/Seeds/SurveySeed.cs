using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SurveyApi.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Repository.Seeds
{
    internal class SurveySeed : IEntityTypeConfiguration<Survey>
    {
        public void Configure(EntityTypeBuilder<Survey> builder)
        {
            builder.HasData(new Survey
            {
                Id = 1,
                Name = "Magaza Degerlendirme",
                IsActive = true,
                CreatedDate = DateTime.Now
            },
            new Survey
            {
                Id = 2,
                Name = "Teknik Servis Degerlendirme",
                IsActive = true,
                CreatedDate = DateTime.Now
            });
        }
    }
}
