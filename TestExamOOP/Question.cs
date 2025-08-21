using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{


    internal abstract class Question
    {
       public string Header { get;  set; }

        public string Body { get; set; }

        public double Mark { get; set; }

        public List<Answer> Answers;

        public QuestionType type;

        public Question(string header, string body, double mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = new List<Answer>();
        }


        public abstract void SHowQuestion();
    }



    internal enum QuestionType
    {
        MCQ,
        TrueFalse

    }




    internal class SimpleQuestion : Question
    {
        public SimpleQuestion(string header, string body, double mark) : base(header, body, mark)
        {
           
        }
        public override void SHowQuestion()
        {
            Console.WriteLine($"Header: {Header}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine($"Mark: {Mark}");
            Console.WriteLine("Answers:");
            foreach (var answer in Answers)
            {
                Console.WriteLine($"- {answer.Answer_Number}: {answer.Answer_Text}");
            }
        }
    }
 }
