using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizBer
{
    class Program
    {
        static void Main(string[] args)
        {
            var quizQuestions = new List<Question>();
            //var questionOne = new TrueFalseQuestion()
            //{
            //    QuestionString = "A smoker is a type of grill.",
            //    CorrectAnswerBool = true
            //};
            //quizQuestions.Add(questionOne);

            //var questionTwo = new TrueFalseQuestion()
            //{
            //    QuestionString = "The most popular utensil among grill owners is a long handled spatuala.",
            //    CorrectAnswerBool = false
            //};
            //quizQuestions.Add(questionTwo);

            //var questionThree = new FillInTheBlankQuestion()
            //{
            //    QuestionString = "In 2009 competitive eating champion Joey Chestnut ate __ hot dogs with buns in 10 minutes!",
            //    CorrectAnswerString = "68"
            //};
            //quizQuestions.Add(questionThree);

            //var questionFour = new OrderQuestion(new[]
            //    {
            //        "Humans discover fire",
            //        "The outdoor gas grill was invented",
            //        "George Foreman grill invented"
            //    })
            //{
            //    QuestionString = "Put the following items in chronological order:",

            //};

            //quizQuestions.Add(questionFour);

            var questionFive = new MultipleChoiceQuestion()
            {
                QuestionString = "Which of the following is the correct definition of a grill?",
                PossibleAnswers = new List<string>()
                 {
                    "A metal framework used for cooking food over an open fire.",
                    "A device for recording visual images in the form of photographs, film, or video signals.",
                    "A wipeable board with a white surface used for teaching or presentations.",
                    "The star around which the earth orbits."
                },
                CorrectAnswerIndex = 0
            };

            quizQuestions.Add(questionFive);

            Console.WriteLine("Welcome to QuizBer!");
            Console.WriteLine();
            Console.WriteLine("Running 'Basic Grill Quiz'");
            Console.WriteLine();
            Console.WriteLine("Press Enter to start the quiz!");
            Console.ReadLine();

            Console.Clear();

            foreach (var question in quizQuestions)
            {
                Console.WriteLine(question.QuestionTypeDisplay);
                Console.WriteLine();
                foreach (var line in question.DisplayQuestion())
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("-----------------------------");

                string[] response = new string[question.NumRequiredAnswers];
                for (int i = 0; i < question.NumRequiredAnswers; i++)
                {
                    Console.Write(">> ");
                    response[i] = Console.ReadLine();
                }

                if (question.AttemptAnswer(response))
                {
                    Console.WriteLine("That is correct!");
                }
                else
                {
                    Console.WriteLine("Sorry, that is incorrect.");
                }

                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }



            Console.ReadLine();
        }
    }
}
