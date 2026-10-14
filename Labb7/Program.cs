namespace Labb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the capital city quiz!\n" +
                "You can earn points by answering correctly.\n" +
                "Some questions will earn you more points than others... Good luck!\n");

            //list with questions
            List<Question> questions = new List<Question>()
            {
                new Question("What is the capital city of Sweden?", "Stockholm", 1),
                new Question("What is the capital city of Belgium?", "Brussels", 1),
                new Question("What is the capital city of Norway?", "Oslo", 1),
                new Question("What is the capital city of China?", "Beijing", 2),
                new Question("What is the capital city of Japan?", "Tokyo", 2),
                new Question("What is the capital city of Myanmar", "Naypyidaw", 3)
            };

            //int for user score
            int userScore = 0;
            int maxScore = 0;

            //calculate the maximum amount of points
            foreach (Question q in questions)
            {
                maxScore += q.Points;
            }

            // Create a random number generator
            Random random = new Random();

            /* Loop through the list from the last index to the first.
             * Generate a random index.
             * Swap the question at index i with the question at the random index.
             * Repeating this for all indexes shuffles the list.
             */
            for (int i = questions.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);

                Question temp = questions[i];
                questions[i] = questions[j];
                questions[j] = temp;
            }

            //write out all questions in the list
            foreach (Question q in questions)
            {
                Console.WriteLine(q.Text);
                string userAnswer = Console.ReadLine() ?? "";

                //check if user answer is correct
                if (userAnswer.ToLower() == q.Answer.ToLower()) //if correct
                {
                    Console.WriteLine($"Correct! You earn {q.Points} point(s)!\n"); //write out correct
                    userScore += q.Points; //up the score of the user with the amount of points gained per question
                }
                else //if not correct, write out they replied wrongly and give the correct answer
                {
                    Console.WriteLine($"Wrong! The correct answer is {q.Answer}. You did not earn any points here.\n");
                }
            }

            //once all questions have been asked, show score overview + message about score
            Console.WriteLine("=== GAME OVER ===");
            Console.WriteLine($"Your score: {userScore}/{maxScore}");


            if (userScore == maxScore) //if user has all answers right
            {
                Console.WriteLine("Perfect score!");
            }
            else if (userScore >= maxScore / 2) //if user got at least half of the points
            {
                Console.WriteLine("Good job!");
            }
            else //if user had less than half of the points
            {
                Console.WriteLine("Keep practicing!");
            }
        }
    }
}
