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
    public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(AppDbContext context) : base(context)
        {
        }

   
        public async Task<List<Question>> GetQuestionDetails()
        {       
                return await _context.Questions.Include(x => x.Answer)
                    .ToListAsync();
            
        }

        public async Task<List<Question>> GetQuestionDetailById(int questionId)
        {
            return await _context.Questions.Include(x => x.Answer)
                .Where(x=>x.Id==questionId)
                .ToListAsync();

        }
    }
}
