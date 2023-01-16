using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);
        string gradeLetter;
        if (gradeNumber >= 90 && gradeNumber <= 100)
            gradeLetter = "A";
        else if (gradeNumber >= 80 && gradeNumber < 90)
            gradeLetter = "B";
        else if (gradeNumber >= 70 && gradeNumber < 80)
            gradeLetter = "C";
        else if (gradeNumber >= 60 && gradeNumber < 70)
            gradeLetter = "D";
        else if (gradeNumber >= 0 && gradeNumber < 60)
            gradeLetter = "F";
        else
            gradeLetter = "Error";
        Console.WriteLine($"Your grade is {gradeLetter}");
    }
}