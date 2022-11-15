namespace FizzBuzzTests.edu.wctc.Services;

public class FizzBuzzService
{
    public static string FizzBuzzify(int input)
    {
        var returnString = "";
        
        for (var i = 1; i <= input; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                returnString += " FizzBuzz,";
            } 
            else if (i % 5 == 0)
            {
                returnString += " Buzz,";
            } 
            else if (i % 3 == 0)
            {
                returnString += " Fizz,";
            }
            else
            {
                returnString += $" {i},";
            }
        }

        return returnString;
    }
}