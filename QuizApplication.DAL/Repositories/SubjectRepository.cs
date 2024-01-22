using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizApplication.DAL.Interfaces;
using QuizApplication.DAL.Models;

namespace QuizApplication.DAL.Repositories
{
    public class SubjectRepository : IBaseRepository<Subject>
    {
        private readonly ApplicationContext _context;

        public SubjectRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Create(Subject entity)
        {
            await _context.Subjects.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Subject entity)
        {
            _context.Subjects.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Subject> GetAll()
        {
            return _context.Subjects.AsQueryable();
        }

        public async Task<Subject> Update(Subject entity)
        {
            _context.Subjects.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}