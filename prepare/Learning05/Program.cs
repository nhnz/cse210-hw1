using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Benette", "Multiplication");
        assignment1.GetSummary();
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Rorbert Rodriguez","Fractions","7.3","8-19");
        assignment2.GetSummary();
        assignment2.GetHomeWorkList();
        Console.WriteLine($"\n{assignment2.GetSummary()}");
        Console.WriteLine($"{assignment2.GetHomeWorkList()}");

        WrittingAssignment assignment3 = new WrittingAssignment("Marry Waters","European History","The Causes of World War II by Marry Waters");
        assignment3.GetWrittingInformation();
        Console.WriteLine($"\n{assignment3.GetWrittingInformation()}\n");


    }
}