using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(FizzBuzz(5));
        Console.WriteLine(FizzBuzz(10));
        Console.WriteLine(FizzBuzz(15));
        Console.WriteLine(FizzBuzz(3));
        Console.WriteLine(FizzBuzz(2));
    }

    public static string FizzBuzz(int num)
    {
        var answer = "";

        if (num % 3 == 0)
        {
            answer = "fizz";
        }

        if (num % 5 == 0)
        {
            answer += "buzz";
        }

        if ((num % 3 != 0) && (num % 5 != 0))
        {
            answer = "Not divisible by 3 or 5";
        }

        return answer;
    }
}