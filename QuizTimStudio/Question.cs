using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTimeStudio
{
    public abstract class Question
    {
        public string Text { get; internal set; }

        public Question(string text)
        {
            this.Text = text;
        }

        public abstract void Display();
        public abstract bool IsCorrect();
    }
}
