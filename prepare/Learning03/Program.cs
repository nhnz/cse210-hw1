using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3,4);

        // Verify that we can call getters and setters (1/1) 
        //fraction1.SetTop(2);
        //fraction1.SetBottom(2);
        Console.WriteLine($"{fraction1.GetFractionString()} \n{fraction1.GetDecimalValue()}");

        // Verify that we can call getters and setters (5/1)
        //fraction2.SetBottom(2);
        
        Console.WriteLine($"{fraction2.GetFractionString()} \n{fraction2.GetDecimalValue()}");

        // Verify that we can call getters and setters (6/7)
        Console.WriteLine($"{fraction3.GetFractionString()} \n{fraction3.GetDecimalValue()}");

        //Verify that we can retrieve and display different representations for a few different fractions
        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine($"{fraction4.GetFractionString()} \n{fraction4.GetDecimalValue()}");

        //Fraction fraction5 = new Fraction(5, 1);
        //Console.WriteLine($"Fraction 5: {fraction5.GetFractionString()} = {fraction5.GetDecimalValue()}");

    }      

        
}