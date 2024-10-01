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
        var a = 10;
        var b = 6;

        Console.WriteLine(a & b);
        Console.WriteLine(a | b);
        Console.WriteLine(a ^ b);

        Console.WriteLine(a<<3);
        Console.WriteLine(b>>1);

    }

}

