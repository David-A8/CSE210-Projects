using System;

class Program
{
    static void Main(string[] args)
    {
        Boolean verify = false;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        float sum = 0;
        int largest = 0;
        while (verify == false)
        {
            Console.WriteLine("Enter number: ");
            string numberEnter = Console.ReadLine();
            int number = int.Parse(numberEnter);
            if (number == 0)
                verify = true;
            else
            {
                numbers.Add(number);
                sum = sum + number;
                if (number > largest)
                    largest = number;
            }            
        }
        float average = sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        
    }
}