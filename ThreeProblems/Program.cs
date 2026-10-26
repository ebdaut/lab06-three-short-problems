/*
*Name: Ethan Daut
*Course: CSCI 1250, Section 002
*Assignment: Lab 06, Three Short Problems
*Date: October 25, 2026
*Description: A menu that keeps running until the user quits, offering three
*independent exercies or all three at once. Each exercise practices decisions
*and one of the four loops.
*/

using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using System.Runtime.CompilerServices;

int choice;
Random rng = new Random(4000);

// do while loop that repeats the code until the user quits
do
{

// context information
Console.WriteLine("\n=== CSCI 1250 Lab 06 ===");
Console.WriteLine("1. The Grade Checker");
Console.WriteLine("2. The Dice Table");
Console.WriteLine("3. The Score Report");
Console.WriteLine("4. All Three");
Console.WriteLine("5. Quit");

System.Console.Write("Choose Options 1-5: ");
choice = Convert.ToInt32(Console.ReadLine());

// if the user doesnt choose 1-5, it repeats
while (choice < 1 || choice > 5)
    {
        System.Console.WriteLine ("Choose a number 1-5. ");
        choice = Convert.ToInt32(Console.ReadLine());
    }

// user choice for the grade checker
if (choice == 1 || choice == 4)
{
    bool validInput = false;
    char gradeLetter;
    System.Console.WriteLine("\n=== Exercise 1: The Grade Checker ===");

    while (!validInput)
        {
            System.Console.Write("Insert a number grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());
            if (grade >= 0 && grade <= 100)
            {
                grade = Convert.ToInt32(grade);
                validInput = true;
                if (grade >= 90)
                {
                    gradeLetter = 'A';
                }
                else if (grade >= 80)
                {
                    gradeLetter = 'B';
                }
                else if (grade >= 70)
                {
                    gradeLetter = 'C';
                }
                else if (grade >= 60)
                {
                    gradeLetter = 'D';
                }
                else
                {
                    gradeLetter = 'F';
                }
                System.Console.WriteLine($"{grade} earns a {gradeLetter}");
            }
            else
            {
                System.Console.WriteLine("Please enter a score between 0 and 100.");
            }
        }

}

// user choice for the dice table
if (choice == 2 || choice == 4)
{
    char rollAgain = 'y';
    int rollAmount = 0;
    int wonAmount = 0;
    System.Console.WriteLine("\n=== Exercise 2: The Dice Table ===");

    while(rollAgain != 'n')
        {
            rollAmount++;
            int userRoll = rng.Next(1,7);
            int secondUserRoll = rng.Next(1,7);
            int totalRollAmount = userRoll + secondUserRoll;
            string outcome;
            
            if (userRoll == 1 && secondUserRoll == 1)
            {
                outcome = "Snake Eyes!";
            }
            else if (userRoll == secondUserRoll)
            {
                outcome = "Doubles!";
            }
            else if (totalRollAmount == 7 || totalRollAmount == 11)
            {
                outcome = "Winner!";
                wonAmount ++;
            }
            else
            {
                outcome = "";
            }
             System.Console.WriteLine($"Roll: {userRoll} and {secondUserRoll}. Total {totalRollAmount}. {outcome}");
             System.Console.WriteLine("Would you like to roll again? (y/n): ");
             rollAgain = Console.ReadLine()[0];
        }
        System.Console.WriteLine($"You rolled {rollAmount} and won {wonAmount}.");
}

// user choice for picking the score report and picking all three as well
if (choice == 3 || choice == 4)
{
    int[] scoreValues = new int[5];
    int total = 0;
    int passingAmount = 0;
    const int minPassingScore = 50;
    System.Console.WriteLine("\n=== Exercise 3: The Score Report ===");

    for (int i = 0; i < scoreValues.Length; i++)
    {
        System.Console.WriteLine($"Score {i + 1}: ");
        scoreValues[i] = Convert.ToInt32(Console.ReadLine());
    }
    int maxScores = scoreValues.Max();
    foreach(int score in scoreValues)
        {
            total += score;

            if (score >= minPassingScore)
            {
                passingAmount++;
            }
        }
        double average = Convert.ToDouble(total)/scoreValues.Length;

        System.Console.WriteLine($"Scores Entered: {scoreValues.Length}");
        System.Console.WriteLine($"Total: {total}");
        System.Console.WriteLine($"Average: {average}");
        System.Console.WriteLine($"Highest: {maxScores}");
        System.Console.WriteLine($"Passing: {passingAmount} of {scoreValues.Length}");
    }
}
while(choice != 5);
Console.WriteLine("\nGoodbye.");
