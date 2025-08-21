using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    internal class PracticalExam : Exam
    {


        public PracticalExam(QuestionType type, int time, int numberOfQuestions) : base(type, time, numberOfQuestions)
        {

        }


        public override void ShowExam()
        {
            Console.WriteLine("Final Exam Details:");
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Time: {Time} minutes");
            Console.WriteLine($"Number of Questions: {NumberOfQuestions}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ---- Questions  ----");

            foreach (var question in questions)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine($"- {question.Header}: {question.Body} (Mark: {question.Mark})");
                Console.WriteLine("");

                foreach (var answer in question.Answers)
                {

                    Console.WriteLine($"  Answer {answer.Answer_Number}: {answer.Answer_Text}");

                }
            }

        }








        }
    }

