namespace Labb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create list with questions, using a method (see Methods.cs)
            List<Question> questions = Methods.CreateQuestions();

            //calculate the max score a user can get, using a method (see Methods.cs)
            int maxScore = Methods.CalculateMaxScore(questions);

            //shuffle the questions, using a method (see Methods.cs)
            Methods.ShuffleQuestions(questions);

            //play the quiz, includes a welcome message
            //calculates the user score by playing the quiz, using a method (see Methods.cs)
            int userScore = Methods.RunQuiz(questions);

            //show the result with a message, using a method (see Methods.cs)
            Methods.ShowResult(userScore, maxScore);
        }
    }
}