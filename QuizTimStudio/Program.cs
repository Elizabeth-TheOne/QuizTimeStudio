using System;
using System.Collections.Generic;

namespace QuizTimeStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            var birdAnswers = new List<string>() {"Code", "Bake", "Fly"};
            var doBirds = new MultipleChoiceQuestion("Do Birds?", birdAnswers, "Fly");

            var catAnswers = new List<string>() { "Sleep", "Go to mars", "Mow the grass" };
            var doCats = new MultipleChoiceQuestion("Do Cats?", catAnswers, "Sleep");

            var trueOrFalse = new TrueFalseQuestion("Is the sky blue?", "True");

            var questions = new List<Question>() { doBirds, doCats, trueOrFalse };
            foreach(Question question in questions)
            {
                question.Display();
                Console.WriteLine("Correct? " + question.IsCorrect());
            }

        }
    }
}
