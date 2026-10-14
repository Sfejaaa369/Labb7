using System;
using System.Collections.Generic;
using System.Text;

namespace Labb7
{
    internal class Methods
    {
        //method for welcome message
        public static void WriteWelcomeMessage()
        {
            Console.WriteLine(
                "Welcome to the capital city quiz!\n" +
                "You can earn points by answering correctly.\n" +
                "Some questions will earn you more points than others... Good luck!\n");
        }

        //method for calculating maxscore
        public static int CalculateMaxScore(List<Question> questions)
        {
            int maxScore = 0;

            foreach (Question q in questions)
            {
                maxScore += q.Points;
            }

            return maxScore;
        }

        //method for shuffling the questions in the list
        public static void ShuffleQuestions(List<Question> questions)
        {
            Random random = new Random();

            for (int i = questions.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);

                Question temp = questions[i];
                questions[i] = questions[j];
                questions[j] = temp;
            }
        }

        //method for running the quiz game
        public static int RunQuiz(List<Question> questions)
        {
            int userScore = 0;

            foreach (Question q in questions)
            {
                Console.WriteLine(q.Text);
                string userAnswer = Console.ReadLine() ?? "";

                if (userAnswer.ToLower() == q.Answer.ToLower())
                {
                    Console.WriteLine($"Correct! You earn {q.Points} point(s)!\n");
                    userScore += q.Points;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer is {q.Answer}.\n");
                }
            }

            return userScore;
        }

        //method for showing result
        public static void ShowResult(int userScore, int maxScore)
        {
            Console.WriteLine("=== GAME OVER ===");
            Console.WriteLine($"Your score: {userScore}/{maxScore}");

            if (userScore == maxScore)
            {
                Console.WriteLine("Perfect score!");
            }
            else if (userScore >= maxScore / 2)
            {
                Console.WriteLine("Good job!");
            }
            else
            {
                Console.WriteLine("Keep practicing!");
            }
        }
    }
}
