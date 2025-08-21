using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    internal class Subject
    {
      public int id { get; set; }

     public string name { get; set; }
     
       public Exam? exam { get; set; } 

        public Subject(int id, string name)
        {
            this.id = id;
            this.name = name;
            exam = null; 
        }
        void createExam(QuestionType type, int time, int numberOfQuestions , string Name)
        {
            
        }

       
    }
}
