using System;
using System.Collections.Generic;
using System.Text;

namespace QuizAssignment
{
    class Question
    {
        protected string Text { get; set; }
        protected string CorrectAnswer { get; set; }

        public Question()
        {
            Text = "";
            CorrectAnswer = "";
        }


        public Boolean CheckAnswer(string a) {
            return a.Equals(CorrectAnswer);
        }

        public void Display() {
            Console.WriteLine(Text);
        }

    }
}
