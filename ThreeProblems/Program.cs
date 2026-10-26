using System.Xml.Serialization;

int choice;
Random rng = new Random(4000);

Console.WriteLine("\n=== CSCI 1250 Lab 06 ===");
Console.WriteLine("1. The Grade Checker");
Console.WriteLine("2. The Dice Table");
Console.WriteLine("3. The Score Report");
Console.WriteLine("4. All Three");
Console.WriteLine("5. Quit");

System.Console.Write("Choose Options 1-5: ");
choice = Convert.ToInt32(Console.ReadLine());

do
{
if (choice == 1 || choice == 4)
{
    bool validInput = false;
    char gradeLetter;
    System.Console.WriteLine("\n=== Exercise 1: The Grade Checker ===");

}

if (choice == 2 || choice == 4)
{
    char rollAgain = 'y';
    int rollAmount = 0;
    int wonAmount = 0;
    System.Console.WriteLine("\n=== Exercise 2: The Dice Table ===");
}

if (choice == 3 || choice == 4)
{
    int[] scoreValues = new int[5];
    int total = 0;
    int passingAmount = 0;
    System.Console.WriteLine("\n=== Exercise 3: The Score Report ===");
}
if (choice < 1 || choice > 5)
{
    System.Console.WriteLine("Choose a number from 1 to 5");
    }
}
while(choice != 5);
Console.WriteLine("\nGoodbye.");