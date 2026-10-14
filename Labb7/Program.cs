namespace Labb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //write a welcome message to the user, using a method (see Methods.cs)
            Methods.WriteWelcomeMessage();

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

            //calculate the max score a user can get, using a method (see Methods.cs)
            int maxScore = Methods.CalculateMaxScore(questions);

            //shuffle the questions, using a method (see Methods.cs)
            Methods.ShuffleQuestions(questions);

            //calculate the user score by playing the quiz, using a method (see Methods.cs)
            int userScore = Methods.RunQuiz(questions);

            //show the result with a message, using a method (see Methods.cs)
            Methods.ShowResult(userScore, maxScore);
        }
    }
}
       

        
    
