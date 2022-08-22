namespace MVC_Assignment.Models
{
    public class GameModel
    {

        public static int CorrectAnswer { get; set; }

        public static int Attempts { get; set; }


        public static string GetResult(int guessedNumber)
        {
            if(guessedNumber < 0 || guessedNumber > 100)
            {
                return "Please enter an int between 0 and 100!";
            } else if(guessedNumber > CorrectAnswer)
            {
                Attempts++;
                return "Number is lower, try again. Attempts made: " + Attempts;
            } else if(guessedNumber < CorrectAnswer)
            {
                Attempts++;
                return "Number is higher, try again. Attempts made: " + Attempts;
            }
            else
            {
                if (Attempts > 0)
                {
                    return "You have guessed right. Correct answer: " + CorrectAnswer + ". Attempts made: " + Attempts;
                }
                return "You have guessed right. Correct answer: " + CorrectAnswer;

            }

        }

        internal static int GetRandomNumber()
        {
            Random random = new Random();

            return random.Next(1, 101);

        }
    }
}
