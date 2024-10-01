using System;
using System.Linq.Expressions;
class Program
{
    static void Main(string[] args)
    {
        // Unary operators
        // var x = 5;

        // Console.WriteLine("post increment:");
        // int postIncrement = x++;
        // Console.WriteLine(postIncrement);
        // Console.WriteLine(x);

        // Console.WriteLine("pre increment:");
        // int preIncrement = ++x;
        // Console.WriteLine(preIncrement);
        // Console.WriteLine(x);

        // Console.WriteLine("post decrement:");
        // int postDecrement = x--;
        // Console.WriteLine(postDecrement);
        // Console.WriteLine(x);

        // Console.WriteLine("pre decrement:");
        // int preDecrement = --x;
        // Console.WriteLine(preDecrement);
        // Console.WriteLine(x);


        // bitwise and binary shift operators
        // var a = 10;
        // var b = 6;

        // Console.WriteLine(a & b);
        // Console.WriteLine(a | b);
        // Console.WriteLine(a ^ b);

        // Console.WriteLine(a<<3);
        // Console.WriteLine(b>>1);


        //<------------------simple calculator------------------>

        // double num1, num2;
        // string operation;

        // Console.WriteLine("Simple calculator in C#");

        // get the number from the user
        // Console.Write("Enter the first number: ");
        // num1 = Convert.ToDouble(Console.ReadLine());

        // get the second number from the user
        // Console.Write("Enter the second number: ");
        // num2 = Convert.ToDouble(Console.ReadLine());

        // get the operation from the user
        // Console.WriteLine("Choose an operation: +,-,*,/ ");
        // operation = Console.ReadLine();


        // perform the calculation based on the operation
        // switch (operation){
        //     case "+":
        //         Console.WriteLine($"Result: {num1} + {num2} = {num1+num2}");
        //         break;
        //     case "-":
        //         Console.WriteLine($"Result: {num1} - {num2} = {num1-num2}");
        //         break;
        //     case "*":
        //         Console.WriteLine($"Result: {num1} * {num2} = {num1*num2}");
        //         break;
        //     case "/":
        //         Console.WriteLine($"Result: {num1} / {num2} = {num1/num2}");
        //         break;
        // }
        //<------------------simple calculator------------------>

        //<------------------Branching with the switch statement------------------>
        var number = (new Random().Next(1, 5));
        string message;

        switch (number)
        {
            case 1:
                message = "One";
                goto MyLabel;
            case 2:
                message = "Two";
                goto LastLabel; ;
            default:
                message = "Default";
                break;
            case 3:
                message = "three";
                break;
        }
    MyLabel:
        Console.WriteLine("Some statements...");

    LastLabel:
        Console.WriteLine($"The message is {message}.");
    }

}

