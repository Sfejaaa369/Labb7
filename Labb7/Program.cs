namespace Labb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list with questions
            List<Question> questions = new List<Question>()
            {
                new Question("What is the capital city of Sweden?", "Stockholm"),
                new Question("What is the capital city of Belgium?", "Brussels"),
                new Question("What is the capital city of Norway?", "Oslo"),
                new Question("What is the capital city of China?", "Beijing"),
                new Question("What is the capital city of Japan?", "Tokyo")
            };

            //int for user score
            int userScore = 0;

            //write out each question in the list
            foreach (Question q in questions)
            {
                Console.WriteLine(q.Questions);
                string userAnswer = Console.ReadLine(); //save user answer

                //check if user answer is correct
                if (userAnswer.ToLower() == q.Answers.ToLower()) //if correct
                {
                    Console.WriteLine("Correct! You earn one point!\n"); //write out correct
                    userScore++; //up the score of the user
                }
                else //if not correct, write out they replied wrongly and give the correct answer
                {
                    Console.WriteLine($"Wrong! The correct answer is {q.Answers}. You did not earn any points here.\n");
                }
            }

            //once all questions have been asked, show score overview
            Console.WriteLine("=== GAME OVER ===");
            Console.WriteLine($"Your score: {userScore}/{questions.Count}");


            if (userScore == questions.Count) //if user has all answers right
            {
                Console.WriteLine("Perfect score!"); //write they had a perfect score
            }
            else if (userScore >= questions.Count / 2) //if user had at least half of answers right
            {
                Console.WriteLine("Good job!"); //write they did a good job
            }
            else //if user had less than half of answers right
            {
                Console.WriteLine("Keep practicing!"); //tell them to keep practising
            }
        }
    }
}
    
}

