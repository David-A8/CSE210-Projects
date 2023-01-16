using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);
        bool verify = false;
        while(verify == false)
        {
            Console.WriteLine("What is the magic number? ");
            string inputNum = Console.ReadLine();
            int numberInput = int.Parse(inputNum);
            if (numberInput > number)
            {
                Console.WriteLine("Lower");
            }
            if (numberInput < number)
            {
                Console.WriteLine("Higher");
            }
            if (numberInput == number)
            {
                Console.WriteLine("You guessed it!");
                verify = true;
            }
        }
    }
}