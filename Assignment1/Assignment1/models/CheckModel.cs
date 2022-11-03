namespace Assignment1.models
{
    public class CheckModel
    {
        public static string CheckAge(int age)
        {
            if(age <= 18)
            {
                return "you are not old enough";
            }
            else
            {
                return "you are old enough";
            }
        }

    }
}
