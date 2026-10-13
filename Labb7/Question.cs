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
        public int Point { get; set; }

        //konstruktor
        public Question(string question, string answer)
        {
            Text = question;
            Answer = answer;
        }
    }
}
