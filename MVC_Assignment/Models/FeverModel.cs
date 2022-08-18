namespace MVC_Assignment.Models
{
    public class FeverModel
    {

        public static string CheckFever(float temperature)
        {
            if(temperature >= 37)
            {
                return "You have fever! Get some rakija and smear on your feet, it helps.";
            } else if (temperature < 37)
            {
                return "You are well, no need to worry!";
            }
            else
            {
                return "Please enter your body temperature!";
            }
        }
    }
}
