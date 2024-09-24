// Using System
using System;
using System.Runtime.CompilerServices;
class Program
{
    static string[] names = ["Alice", "Bob", "Charlie", "Diana", "Eve"];


    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World");
        // Ask for student Id
        // Console.Write("Enter your london met Id:");
        // string studentId = Console.ReadLine();

        // Ask for student name
        // Console.Write("Enter your name:");
        // string studentName = Console.ReadLine();

        // Ask for student's age
        // Console.Write("Enter your age:");
        // int studentAge = Convert.ToInt32(Console.ReadLine());

        // Ask for gender
        // Console.Write("Enter your gender:");
        // string studentGender = Console.ReadLine();

        // Print the student details
        // Console.WriteLine("\nStudent details:");
        // Console.WriteLine("Id:" + studentId);
        // Console.WriteLine("Name:" + studentName);
        // Console.WriteLine("Age:" + studentAge);
        // Console.WriteLine("Gender:" + studentGender);

        // adding two numbers
        // Console.WriteLine("Enter first number:");
        // int num1 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter second number:");
        // int num2 = Convert.ToInt32(Console.ReadLine());
        // var sum = num1+num2;
        // Console.WriteLine("\nSum:"+ sum );


        Console.WriteLine("Name of peoples:");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}



