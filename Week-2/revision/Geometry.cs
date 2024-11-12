class Geometry{
    Console.WriteLine("Select a shape to calculate area and perimeter:");
    Console.WriteLine("1.Circle")
    Console.WriteLine("2.Rectangle")
    Console.WriteLine("3.Triangle")
    Console.Write("Enter your choice (1,2,3):")
    int choice = Convert.ToInt32(console.ReadLine());
    switch (choice)
    {
        case 1:
        // go to circle method
        break;
        case 2:
        // go to rectangle method
        case 3:
        // go to triangle method
        default:
        Console.WriteLine("Invalid!.... Enter the correct choice (1,2,3):");

    }

}