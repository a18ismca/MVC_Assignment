namespace MVC_Assignment.Models
{
    public class GameModel
    {

        public static int CorrectAnswer { get; set; }

        public static string Statement { get; set; }
        public static int Attempts { get; set; }

        

        public static bool GetResult(int guessedNumber, int randomNumber)
        {
            if(guessedNumber < 0 || guessedNumber > 100)
            {
                Statement = "Please enter an int between 0 and 100!";
                return false;

            } else if(guessedNumber > randomNumber)
            {
                Attempts++;
                Statement = "Number is lower, try again. Attempts made: " + Attempts;
                return false;

            } else if(guessedNumber < randomNumber)
            {
                Attempts++;
                Statement = "Number is higher, try again. Attempts made: " + Attempts;
                return false;
            }
            else
            {

                Statement = "You have guessed right. Correct answer: " + randomNumber + ". Attempts made: " + Attempts;
               
                randomNumber = GetRandomNumber();

                Statement = "The game has restarted. New number: " + randomNumber;

                Attempts = 0;

                return true;

            }

        }

        public static int GetRandomNumber()
        {
            Random random = new Random();

            return random.Next(1, 101);

        }
    }
}
