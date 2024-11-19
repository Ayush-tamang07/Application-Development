using System;

class Program
{
    public static void Main(string[] args)
    {
        // Exercise 1
        // string fullName = GetFullName("Ayush", "Tamang");
        // Console.WriteLine(fullName);

        // Exercise 2
        // static int Add(int x,int y){
        //     return x + y;
        // }
        // int result1 = Add(2,3);
        // Console.WriteLine(result1);


        // Exercise 3.1
        // Console.WriteLine($"Sum of 5 and 6 is {CalculateSum(5,6)}");
        // Console.WriteLine($"Sum of 10 and 20 is {CalculateSum(10,20)}");
        // Console.WriteLine($"Sum of 20 and 40 is {CalculateSum(20,40)}");


        // Exercise 3.2
        // PrintMultiples(3);

        // RecursiveFactorial
        int result = RecursiveFactorial(4);
        Console.WriteLine($"Factorial of 4 is: {result}");

    }

    // Exercise 1
    // static String GetFullName(string firstName, string lastName)
    // {
    //     // fullName = ($"{firstName}{lastName}");
    //     if (lastName == "")
    //     {
    //         return firstName;
    //     }
    //     if (firstName == "")
    //     {
    //         return lastName;
    //     }
    //     var fullName = $"{firstName} {lastName}";
    //     return fullName;

    // }

    // Exercise 3.1
    // static int CalculateSum(int a, int b)
    // {
    //     return a + b;
    // }

    // Exercise 3.2
    // static void PrintMultiples(int n)
    // {
    //     for (int i = 1; i < 6; i++)
    //     {
    //         Console.WriteLine(n * i);
    //     }

    // }

    static int RecursiveFactorial(int n)
    {
        if (n < 2)
            return 1;
        return n * RecursiveFactorial(n - 1);
    }

}