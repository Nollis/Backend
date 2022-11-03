namespace Assignment1.models
{
    public class CheckModel
    {
        public static string CheckTemp(int temp)
        {
            if(temp > 37)
            {
                return "you have a fever!";
            }
            else if(temp == 37)
            {
                return "You have normal temperature";
            }
            else
            {
                return "you have hypothermia!";
            }
        }

    }
}
