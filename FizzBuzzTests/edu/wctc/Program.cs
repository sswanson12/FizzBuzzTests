using FizzBuzzTests.edu.wctc.Services;

var consoleService = new ConsoleService();

consoleService.Print("Please enter an integer, and the program will Fizzbuzzify it.");

consoleService.Print(FizzBuzzService.FizzBuzzify(consoleService.GetIntInput()));