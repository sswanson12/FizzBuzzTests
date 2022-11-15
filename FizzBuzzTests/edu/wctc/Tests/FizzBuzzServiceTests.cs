using FizzBuzzTests.edu.wctc.Services;
using NUnit.Framework;

namespace FizzBuzzTests.edu.wctc.Tests;

[TestFixture]
public class FizzBuzzServiceTests
{
    
    [Test]
    public void FizzTest()
    {
        Assert.AreEqual("1, 2, Fizz.", FizzBuzzService.FizzBuzzify(3));
    }
    
    [Test]
    public void BuzzTest()
    {
        Assert.AreEqual("1, 2, Fizz, 4, Buzz.", FizzBuzzService.FizzBuzzify(5));
    }
    
    [Test]
    public void FizzBuzzTest()
    {
        Assert.AreEqual("1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz.", FizzBuzzService.FizzBuzzify(15));
    }
}