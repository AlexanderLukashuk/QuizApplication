using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuizApplication.DAL.Models;

namespace QuizApplication.DAL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Subject> Subjects = null!;

        public DbSet<Question> Questions = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=quiz_aitu;User ID=sa;Password=pOStgRES1488;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}