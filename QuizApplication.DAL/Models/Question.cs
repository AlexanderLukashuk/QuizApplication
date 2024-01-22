using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApplication.DAL.Models
{
    public class Question : BaseEntity
    {
        public string? QuestionText { get; set; }

        public List<string>? Answers { get; set; }
    }
}