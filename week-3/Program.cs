using System;

class Program
{
    public static void Main(string[] args)
    {
        // var obj = new Program();
        string fullName = GetFullName("Ayush", "Ayush");
        Console.WriteLine(fullName);

        // string fullName = obj.GetFullName("Ayush", "Ayush");
        // Console.WriteLine(fullName);
    }

    static String GetFullName(string firstName, string lastName)
    {
        // fullName = ($"{firstName}{lastName}");
        if (lastName == "")
        {
            return firstName;
        }
        if (firstName == "")
        {
            return lastName;
        }
        var fullName = $"{firstName} {lastName}";
        return fullName;

    }
}