namespace FizzBuzzTests.edu.wctc.Services;

public class ConsoleService
{
    public string? GetStringInput()
    {
        return Console.ReadLine();
    }

    public int GetIntInput()
    {
        int input;

        while (Int32.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Input must be an integer (1, 2, 3, 4, 5...), please try again: ");
        }

        return input;
    }

    public void Print(string printString)
    {
        Console.WriteLine(printString);
    }
}