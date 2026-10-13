using System;
using System.Collections.Generic;
using System.Text;

namespace Labb7
{
    internal class Question
    {
        //properties
        public string Questions { get; set; }
        public string Answers { get; set; }

        //konstruktor
        public Question(string question, string answer)
        {
            Questions = question;
            Answers = answer;
        }
    }
}
