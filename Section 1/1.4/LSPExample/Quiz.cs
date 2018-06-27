using System;
using System.Collections.Generic;
using System.Text;

namespace LSPExample
{
    public class Quiz
    {
        public List<QuizQuestion> MultipleChoiceQuestions = new List<QuizQuestion>()
        {
            new QuizQuestion()
            {
                Question = "Which language came first?",
                Answer1 = "C",
                Answer2 = "C++",
                Answer3 = "Java",
                Answer4 = "C#",
                CorrectAnswer = "C"
            },
            new QuizQuestion()
            {
                Question = "Which of the following is not a JavaScript framework?",
                Answer1 = "React",
                Answer2 = "Iris",
                Answer3 = "Angular",
                Answer4 = "Aurelia",
                CorrectAnswer = "Iris"
            },
            new QuizQuestion()
            {
                Question = "The lightest Linux flavour is: ",
                Answer1 = "Ubuntu",
                Answer2 = "Kubuntu",
                Answer3 = "Lubuntu",
                Answer4 = "Kali Linux",
                CorrectAnswer = "Lubuntu"
            }
        };

        public List<QuizQuestion> TrueFalseQuestions = new List<QuizQuestion>
        {
            new TrueFalseQuestion()
            {
                Question = "Java is an Object Oriented Language",
                CorrectAnswer = "True"
            },
            new TrueFalseQuestion()
            {
                Question = "You can use `docker delete` to remove a docker container",
                CorrectAnswer = "False"
            },
            new TrueFalseQuestion()
            {
                Question = "ls -la displays hidden files",
                CorrectAnswer = "True"
            }
        };

        public void ShowQuestions(List<QuizQuestion> questions)
        {
            QuizQuestionFormatter formatter = new QuizQuestionFormatter();
            foreach (var question in questions)
            {
                Console.WriteLine(formatter.Format(question));
            }
        }
    }
}
