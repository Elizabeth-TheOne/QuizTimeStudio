using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTimeStudio
{
    public class TrueFalseQuestion : MultipleChoiceQuestion
    {

        public TrueFalseQuestion(string text, string correctAnswer)
            : base(text, correctAnswer)
        {
            this.PossibleAnswers = new List<string>() { "True", "False"};
        }
    }
}
