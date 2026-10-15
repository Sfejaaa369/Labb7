using System;
using System.Collections.Generic;
using System.Text;

namespace Labb7
{
    internal class Methods
    {
        //method to create list with questions
        public static List<Question> CreateQuestions()
        {
            return new List<Question>
            {
        new Question("What is the capital city of Sweden?", "Stockholm", 1),
        new Question("What is the capital city of Belgium?", "Brussels", 1),
        new Question("What is the capital city of Norway?", "Oslo", 1),
        new Question("What is the capital city of China?", "Beijing", 2),
        new Question("What is the capital city of Japan?", "Tokyo", 2),
        new Question("What is the capital city of Myanmar?", "Naypyidaw", 3)
            };
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

        //method for shuffling the questions in the list in a random order - AI suggestion
        //before, it was just a foreach loop going through the list, unshuffled
        public static void ShuffleQuestions(List<Question> questions)
        {
            // Create a random number generator
            Random random = new Random();

            // Start from the last question and work backwards
            for (int i = questions.Count - 1; i > 0; i--)
            {
                // Pick a random index between 0 and i
                int j = random.Next(i + 1);

                // Swap the questions at positions i and j
                Question temp = questions[i];
                questions[i] = questions[j];
                questions[j] = temp;
            }
        }

        //method for running the quiz game
        public static int RunQuiz(List<Question> questions)
        {
            //welcome message
            Console.WriteLine(
                "Welcome to the capital city quiz!\n" +
                "You can earn points by answering correctly.\n" +
                "Some questions will earn you more points than others... Good luck!\n");

            int userScore = 0; //start user score at 0

            foreach (Question q in questions) //write out questions from list
            {
                Console.WriteLine(q.Text);
                //ensure user answer is not null- AI suggestion
                //before, it was the same code but without: ?? ""
                string userAnswer = Console.ReadLine() ?? "";

                //ensure user can write without capital letters and still have answer be correct
                //ToLower = AI suggestion
                //before, it was the same but without the ToLower() added
                if (userAnswer.ToLower() == q.Answer.ToLower())
                {
                    Console.WriteLine($"Correct! You earn {q.Points} point(s)!\n");
                    userScore += q.Points; //up the user score with the amount of points the question was worth
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
