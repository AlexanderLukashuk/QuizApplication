using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizApplication.DAL.Interfaces;
using QuizApplication.DAL.Models;

namespace QuizApplication.DAL.Repositories
{
    public class QuestionRepository : IBaseRepository<Question>
    {
        private readonly ApplicationContext _context;

        public QuestionRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Create(Question entity)
        {
            await _context.Questions.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Question entity)
        {
            _context.Questions.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Question> GetAll()
        {
            return _context.Questions.AsQueryable();
        }

        public async Task<Question> Update(Question entity)
        {
            _context.Questions.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}