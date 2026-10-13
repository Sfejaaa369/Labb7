namespace Labb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            //write out each question in the list
            foreach (Question q in questions)
            {
                Console.WriteLine(q.Text);
                //save user answer + make sure it can't be null
                string userAnswer = Console.ReadLine() ?? ""; //AI suggestion: CANNOT BE NULL

                //check if user answer is correct
                //if correct
                if (userAnswer.ToLower() == q.Answer.ToLower()) //AI suggestion: TOLOWER
                {
                    Console.WriteLine($"Correct! You earn {q.Points} point(s)!\n"); //write out correct
                    userScore += q.Points; //up the score of the user
                }
                else //if not correct, write out they replied wrongly and give the correct answer
                {
                    Console.WriteLine($"Wrong! The correct answer is {q.Answer}. You did not earn any points here.\n");
                }
            }

            //once all questions have been asked, show score overview
            Console.WriteLine("=== GAME OVER ===");
            Console.WriteLine($"Your score: {userScore}/{maxScore}");


            if (userScore == maxScore) //if user has all answers right
            {
                Console.WriteLine("Perfect score!"); //write they had a perfect score
            }
            else if (userScore >= maxScore / 2) //if user got at least half of the points
            {
                Console.WriteLine("Good job!"); //write they did a good job
            }
            else //if user had less than half of the points
            {
                Console.WriteLine("Keep practicing!"); //tell them to keep practising
            }
        }
    }
}

