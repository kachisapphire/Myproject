using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Myproject
{
    internal class Quiz
    {
        public string? Questions { get; set; }
        public List<string>? Options { get; set; }
        public string? Answer { get; set; }
        private static List<Quiz> quiz = new List<Quiz>();
        public static void QuizData()
        {
            List<Quiz> shuffledList = new List<Quiz>
            {
                new Quiz()
                {
                    Questions = "Which of the following is not a valid data type in c#?",
                    Options = new List<string>{"(A) String", "(B) Double ", "(C) Int", "(D) Triple"},
                    Answer = "D"
                },
                new Quiz()
                {
                    Questions = "What does HTML stand for?",
                    Options = new List<string> { "(A) Hyper Text Markup Language", "(B) High Tech Markup Language", "(C) Hyperlink and Text Markup Language", "(D) Hyper Transfer Markup Language" },
                    Answer = "A"
                },
                new Quiz()
                {
                    Questions = "Which programming language is commonly used for developing Android apps?",
                    Options = new List<string>{ "(A) Swift", "(B) Java", "(C) C++", "(D) Python" },
                    Answer = "B"
                },
                new Quiz()
                {
                    Questions = "What does CSS stand for?",
                    Options = new List<string>{ "(A) Computer Style Sheets", "(B) Creative Style Sheets", "(C) Cascading Style Sheets", "(D) Colorful Style Sheets" },
                    Answer = "C"
                },
                new Quiz()
                {
                    Questions = "What is the capital of France?",
                    Options = new List<string>{ "(A) Paris", "(B) Rome", "(C) Madrid", "(D) Berlin" },
                    Answer = "A"
                },
                new Quiz()
                {
                    Questions = "Which of the following is not a programming language?",
                    Options = new List<string>{"(A) HTML", "(B) JPEG", "(C) SQL", "(D) Ruby"},
                    Answer = "B"
                },
                new Quiz()
                {
                    Questions = "What does PHP stand for?",
                    Options = new List<string>{ "(A) Personal Home Page", "(B) Hypertext Preprocessor", "(C) Pre Hypertext Processor", "(D) Public Home Page" },
                    Answer = "C"
                },
                new Quiz()
                {
                    Questions = "Who is often called the father of modern physics?",
                    Options = new List<string>{ "(A) Isaac Newton", "(B) Albert Einstein", "(C) Nikola Tesla", "(D) Galileo Galilei" },
                    Answer = "B"
                },
                new Quiz()
                {
                    Questions = "What is the chemical symbol for water?",
                    Options = new List<string>{ "(A) O2", "(B) H2O", "(C) CO2", "(D) H2"},
                    Answer = "B"
                },
                new Quiz()
                {
                    Questions = "What is the fastest land animal?",
                    Options = new List<string>{ "(A) Cheetah", "(B) Lion", "(C) Elephant", "(D) Giraffe"},
                    Answer = "A"
                },
                new Quiz()
                {
                    Questions = "What is the capital of Japan?",
                    Options = new List<string>{ "(A) Beijing", "(B) Seoul", "(C) Tokyo", "(D) Bangdok"},
                    Answer = "C"
                }
            };
            var shuffle = new Random();
            shuffledList = shuffledList.OrderBy(x => shuffle.Next()).ToList();
            quiz = shuffledList;
        }
        public static void QuizLogic()
        {
            int score = 0;
            foreach (var question in quiz)
            {
                Console.WriteLine(question.Questions);
                foreach (var option in question.Options)
                {
                    Console.WriteLine(option);
                }
                Console.WriteLine("Select an option:");
                string result;
                bool selection;
                do
                {
                    result = Console.ReadLine().ToUpper();
                    selection = result == "A" || result == "B" || result == "C" || result == "D";
                    if(!selection)
                    {
                        Console.WriteLine("Invalid selection, choose an option from A - D");
                    }
                }
                while (!selection);
                if (result == question.Answer?.ToUpper())
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                else
                { 
                        Console.WriteLine("Incorrect");
                        Console.WriteLine("Do you want to continue?");
                        Console.WriteLine("Enter Y for Yes or N for No:");
                        string quizcontinue = Console.ReadLine()?.ToUpper();
                        if (quizcontinue == "Y")
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }  
                
            }
            Console.WriteLine("You scored " + score);
        }
        public static void QuizRestart()
        {
            Console.WriteLine("Do you want to try again?");
            Console.WriteLine("Enter Y for yes or N for No:");
            string restart = Console.ReadLine();
            if (restart.ToUpper() == "Y")
            {
                QuizData();
                QuizLogic();
            }
            else
            {
                Console.WriteLine("Thanks for Playing!!!");
            }
        }
                
        
    }
}

