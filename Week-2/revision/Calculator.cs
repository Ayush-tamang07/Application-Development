class Calculator
{
    public void calculate()
    {
        double num1, num2;
        String operation;

        // taking first number from the user
        Console.Write("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        // taking first number from the user
        Console.Write("Enter the Second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        // get the operator 
        Console.Write("Choose an operator: +, -, /, *: ");
        operation = Console.ReadLine();

        switch (operation)
        {
            case "+":
                Console.WriteLine($"Result: {num1 + num2}");
                break;

            case "-":
                Console.WriteLine($"Result: {num1 - num2}");
                break;
            case "*":
                Console.WriteLine($"Result: {num1 * num2}");
                break;
            case "/":
                Console.WriteLine($"Result: {num1 / num2}");
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;
        }
        // Wait for user input before closing 
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}