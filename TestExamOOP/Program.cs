using ExamOOP;
using static System.Formats.Asn1.AsnWriter;

namespace oo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            FinalExam exam = new FinalExam(QuestionType.MCQ, 60, 20);


            exam.questions.AddRange(new List<SimpleQuestion>
        {


            new SimpleQuestion("Q1", "What is OOP?", 5)
            {
                Answers = new List<Answer>
                {
                    new Answer { Answer_Number = 1, Answer_Text = "Object Oriented Programming" },
                    new Answer { Answer_Number = 2, Answer_Text = "Old Over Powered" },
                    new Answer { Answer_Number = 3, Answer_Text = "Output Only Procedure" }
                }
            },



            new SimpleQuestion("Q2", "What is Encapsulation?", 5)
            {
                Answers = new List<Answer>
                {
                    new Answer { Answer_Number = 1, Answer_Text = "Hiding internal details" },
                    new Answer { Answer_Number = 2, Answer_Text = "Showing all code" }
                }
            },



            new SimpleQuestion("Q3", "What is Abstraction?", 5)
            {
                Answers = new List<Answer>
                {
                    new Answer { Answer_Number = 1, Answer_Text = "Hiding complexity" },
                    new Answer { Answer_Number = 2, Answer_Text = "Showing all code" }
                }
            },




            new SimpleQuestion("Q4", "Which of these is a value type?", 5)
            {
                Answers = new List<Answer>
                {
                    new Answer { Answer_Number = 1, Answer_Text = "int" },
                    new Answer { Answer_Number = 2, Answer_Text = "string" },
                    new Answer { Answer_Number = 3, Answer_Text = "object" }
                }
            },



            new SimpleQuestion("Q5", "Which access modifier is most restrictive?", 5)
            {
                Answers = new List<Answer>
                {
                    new Answer { Answer_Number = 1, Answer_Text = "private" },
                    new Answer { Answer_Number = 2, Answer_Text = "public" },
                    new Answer { Answer_Number = 3, Answer_Text = "protected" }
                }
            },


    new SimpleQuestion("Q6", "Which keyword is used to inherit a class in C#?", 5)
    {
        Answers = new List<Answer>
        {
            new Answer { Answer_Number = 1, Answer_Text = "extends" },
            new Answer { Answer_Number = 2, Answer_Text = "inherits" },
            new Answer { Answer_Number = 3, Answer_Text = ":" }
        }
    },


    new SimpleQuestion("Q7", "What does the 'static' keyword mean?", 5)
    {
        Answers = new List<Answer>
        {
            new Answer { Answer_Number = 1, Answer_Text = "Belongs to instance" },
            new Answer { Answer_Number = 2, Answer_Text = "Belongs to class" },
            new Answer { Answer_Number = 3, Answer_Text = "Is inherited only" }
        }
    },


    new SimpleQuestion("Q8", "Which collection type stores unique items only?", 5)
    {
        Answers = new List<Answer>
        {
            new Answer { Answer_Number = 1, Answer_Text = "List" },
            new Answer { Answer_Number = 2, Answer_Text = "Dictionary" },
            new Answer { Answer_Number = 3, Answer_Text = "HashSet" }
        }
    },



    new SimpleQuestion("Q9", "What is boxing in C#?", 5)
    {
        Answers = new List<Answer>
        {
            new Answer { Answer_Number = 1, Answer_Text = "Converting object to value type" },
            new Answer { Answer_Number = 2, Answer_Text = "Converting value type to object" },
            new Answer { Answer_Number = 3, Answer_Text = "Using static variables" }
        }
    },




    new SimpleQuestion("Q10", "Which one is NOT a value type?", 5)
    {
        Answers = new List<Answer>
        {
            new Answer { Answer_Number = 1, Answer_Text = "int" },
            new Answer { Answer_Number = 2, Answer_Text = "string" },
            new Answer { Answer_Number = 3, Answer_Text = "bool" }
        }
    },



    new SimpleQuestion("Q11", "What is the default access modifier in C#?", 5)
    {
        Answers = new List<Answer>
        {
            new Answer { Answer_Number = 1, Answer_Text = "private" },
            new Answer { Answer_Number = 2, Answer_Text = "public" },
            new Answer { Answer_Number = 3, Answer_Text = "internal" }
        }
    },




    new SimpleQuestion("Q12", "What does IDE stand for?", 5)
    {
        Answers = new List<Answer>
        {
            new Answer { Answer_Number = 1, Answer_Text = "Integrated Development Environment" },
            new Answer { Answer_Number = 2, Answer_Text = "International Design Entity" },
            new Answer { Answer_Number = 3, Answer_Text = "Interactive Debug Engine" }
        }
    },




    new SimpleQuestion("Q13", "What is a constructor?", 5)
    {
        Answers = new List<Answer>
        {
            new Answer { Answer_Number = 1, Answer_Text = "Method to create objects" },
            new Answer { Answer_Number = 2, Answer_Text = "Property to destroy objects" },
            new Answer { Answer_Number = 3, Answer_Text = "Event listener" }
        }
    },



    new SimpleQuestion("Q14", "Which of these is a loop in C#?", 5)
    {
        Answers = new List<Answer>
        {
            new Answer { Answer_Number = 1, Answer_Text = "if" },
            new Answer { Answer_Number = 2, Answer_Text = "for" },
            new Answer { Answer_Number = 3, Answer_Text = "try" }
        }
    },




    new SimpleQuestion("Q15", "What is polymorphism?", 5)
    {
        Answers = new List<Answer>
        {
            new Answer { Answer_Number = 1, Answer_Text = "Using one name for multiple behaviors" },
            new Answer { Answer_Number = 2, Answer_Text = "Storing multiple types" },
            new Answer { Answer_Number = 3, Answer_Text = "Writing many classes" }
        }
    },



    new SimpleQuestion("Q16", "What does .NET stand for?", 5)
    {
        Answers = new List<Answer>
        {
            new Answer { Answer_Number = 1, Answer_Text = "Network Enabled Tools" },
            new Answer { Answer_Number = 2, Answer_Text = "No Extra Time" },
            new Answer { Answer_Number = 3, Answer_Text = "Nothing — it's just a name" }
        }
    },



    new SimpleQuestion("Q17", "Which one is used to catch errors in C#?", 5)
    {
        Answers = new List<Answer>
        {
            new Answer { Answer_Number = 1, Answer_Text = "try-catch" },
            new Answer { Answer_Number = 2, Answer_Text = "try-except" },
            new Answer { Answer_Number = 3, Answer_Text = "catch-finally" }
        }
    },




    new SimpleQuestion("Q18", "What is an abstract class?", 5)
    {
        Answers = new List<Answer>
        {
            new Answer { Answer_Number = 1, Answer_Text = "A class with only static methods" },
            new Answer { Answer_Number = 2, Answer_Text = "A class that can't be instantiated" },
            new Answer { Answer_Number = 3, Answer_Text = "A class that extends another" }
        }
    },



    new SimpleQuestion("Q19", "What is the base class of all classes in C#?", 5)
    {
        Answers = new List<Answer>
        {
            new Answer { Answer_Number = 1, Answer_Text = "BaseObject" },
            new Answer { Answer_Number = 2, Answer_Text = "System" },
            new Answer { Answer_Number = 3, Answer_Text = "Object" }
        }
    },





    new SimpleQuestion("Q20", "Which one of these is a reference type?", 5)
    {
        Answers = new List<Answer>
        {
            new Answer { Answer_Number = 1, Answer_Text = "string" },
            new Answer { Answer_Number = 2, Answer_Text = "int" },
            new Answer { Answer_Number = 3, Answer_Text = "bool" }
        }
    }



        });






            foreach (var question in exam.questions)
            {
                exam.Correct_Answer.Add("1");
            }



            Console.WriteLine("----- Exam -----\n");
            exam.ShowExam();



            int score = 0;
            int correctAnswers = 0;

            for (int i = 0; i < exam.questions.Count; i++)
            {
                int userAnswer = 0;
                bool valid = false;

                do
                {
                    Console.Write($"Enter answer number for Q{i + 1}: ");
                    string input = Console.ReadLine();

                    valid = false;

                    if (int.TryParse(input, out userAnswer))
                    {
                        if (userAnswer >= 1 && userAnswer <= 3)
                        {
                            valid = true;
                        }
                    }

                    if (!valid)
                    {
                        Console.WriteLine("❌ Invalid input. Please enter a number between 1 and 3.");
                    }

                } while (!valid);

                if (userAnswer.ToString() == exam.Correct_Answer[i])
                {
                    score += (int)exam.questions[i].Mark;
                    correctAnswers++;
                }
            }

            Console.WriteLine($"\n✅ Total Score: {score} / {exam.questions.Sum(q => q.Mark)}");
            Console.WriteLine($"✅ Correct Answers: {correctAnswers} / {exam.questions.Count}");

            Console.ReadLine();
        }



    }
}
