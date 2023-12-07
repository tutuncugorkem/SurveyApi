using Microsoft.EntityFrameworkCore;
using SurveyApi.Core.DTOs;
using SurveyApi.Core.Models;
using SurveyApi.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Repository.Repositories
{
    public class SurveyRepository : GenericRepository<Survey>, ISurveyRepository
    {
        public SurveyRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Survey>> GetSurveyDetails()
        {
            //eager loading, datayı cekerken bılgılerı alma
            return await _context.Surveys.Include(x=> x.Questions)
                            .ThenInclude(a=>a.Answer)
                .ToListAsync();
        }

       
        public async Task<List<Survey>> GetSurveyDetailsById(int surveyId)
        {
            return await _context.Surveys.Include(x => x.Questions).ThenInclude(a=>a.Answer).Where(x=>x.Id==surveyId).ToListAsync();
        }

       
    }
}
