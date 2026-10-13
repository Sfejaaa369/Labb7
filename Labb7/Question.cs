using System;
using System.Collections.Generic;
using System.Text;

namespace Labb7
{
    internal class Question
    {
        //properties
        public string Text { get; set; }
        public string Answer { get; set; }
        public int Points { get; set; }

        //konstruktor
        public Question(string question, string answer, int points)
        {
            Text = question;
            Answer = answer;
            Points = points;
        }
    }
}
