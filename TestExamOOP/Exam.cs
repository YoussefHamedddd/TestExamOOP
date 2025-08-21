using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    internal abstract class Exam
    {
        public QuestionType type;

        public int Time { get; set; }
        public List<Question> questions;
        public int NumberOfQuestions { get; set; }

        public List<string> Correct_Answer;

        public void Shows_all_Correct_Answers(List<string> l)
        {
            foreach(string item in l)
            {
                Console.WriteLine(item);
            }
        }
    



        public Exam(QuestionType type, int time, int numberOfQuestions )
        {
            this.type = type;
            this.Time = time;
            this.NumberOfQuestions = numberOfQuestions;
            questions = new List<Question>();
            Correct_Answer = new List<string>();
        }
        public abstract void ShowExam();
        

    }


 

}
