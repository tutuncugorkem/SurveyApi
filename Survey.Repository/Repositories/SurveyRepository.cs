using Microsoft.EntityFrameworkCore;
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
            return await _context.Surveys.Include(x=> x.Questions).ToListAsync();
        }
    }
}
