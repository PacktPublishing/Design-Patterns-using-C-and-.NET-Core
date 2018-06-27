using System;

namespace LSPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = new Quiz();
            quiz.ShowQuestions(quiz.TrueFalseQuestions);
            Console.ReadKey();
        }
    }
}