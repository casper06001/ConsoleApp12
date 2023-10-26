using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Skriv in två tal:");
        Console.Write("Tal 1: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Tal 2: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Välj ett räknesätt:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraktion");
        Console.WriteLine("3. Multiplikation");
        Console.WriteLine("4. Division");

        int choice = int.Parse(Console.ReadLine());

        double result = 0;

        switch (choice)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine("Resultatet av additionen är: " + result);
                break;
            case 2:
                result = num1 - num2;
                Console.WriteLine("Resultatet av subtraktionen är: " + result);
                break;
            case 3:
                result = num1 * num2;
                Console.WriteLine("Resultatet av multiplikationen är: " + result);
                break;
            case 4:
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine("Resultatet av divisionen är: " + result);
                }
                else
                {
                    Console.WriteLine("Kan inte dividera med noll.");
                }
                break;
            default:
                Console.WriteLine("Ogiltigt val av räknesätt.");
                break;
        }
    }
}
