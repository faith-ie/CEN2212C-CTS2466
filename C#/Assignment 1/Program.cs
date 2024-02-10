using System;

namespace SpaceVoyagersInc
{
    internal class Program
    {
        private static void Main()
        {
            GetName();
            SelectionMenu();
        }

        private static void GetName()
        {
            Console.WriteLine("     ---Welcome " + Environment.UserName + "---");
        }

        private static void SelectionMenu()
        {
            int numberOfAttempts = 0;
            float oneToFiveZephyrSms = 1.5f;
            float sixOrMoreZephyrSms = 1.0f;
            float oneToFiveTitanSms = 2.5f;
            float sixOrMoreTitanSms = 2.0f;
            int howMuchToBuy;
            int choice;
            do
            {
                Console.WriteLine("Welcome to Space Voyagers Inc.! Choose your adventure:\n1 - Purchase SVI ZEPHYR SMs\n2 - Purchase SVI TITAN SMs\n3 - Exit Program");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    numberOfAttempts++;
                    if (numberOfAttempts == 5)
                    {
                        Console.WriteLine("You have exceeded the number of correct input attempts. We will now exit.");
                        break;
                    }
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("How many SVI ZEPHYR SMs would you like to buy?");
                        if (!int.TryParse(Console.ReadLine(), out howMuchToBuy))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            continue;
                        }
                        if (howMuchToBuy <= 0) Console.WriteLine("Invalid number, value needs to be one or more.");
                        if (howMuchToBuy <= 5)
                        {
                            Console.WriteLine("Calculating your total...\n\n");
                            Console.WriteLine($"For {(float)howMuchToBuy} SVI ZEPHYR SMs, your total is ${oneToFiveZephyrSms * howMuchToBuy} million.\nThank you for choosing Space Voyagers Inc. for your cosmic journey!");
                        }
                        if (howMuchToBuy > 5)
                        {
                            Console.WriteLine("Calculating your total...\n\n");
                            Console.WriteLine($"For {(float)howMuchToBuy} SVI ZEPHYR SMs, your total is ${sixOrMoreZephyrSms * howMuchToBuy} million.\nThank you for choosing Space Voyagers Inc. for your cosmic journey!");
                        }
                        break;

                    case 2:
                        Console.WriteLine("How many SVI TITAN SMs would you like to buy?");
                        if (!int.TryParse(Console.ReadLine(), out howMuchToBuy))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            continue;
                        }
                        if (howMuchToBuy <= 0) Console.WriteLine("Invalid number, value needs to be one or more.");
                        if (howMuchToBuy <= 5)
                        {
                            Console.WriteLine("Calculating your total...\n\n");
                            Console.WriteLine($"For {(float)howMuchToBuy} SVI TITAN SMs, your total is ${oneToFiveTitanSms * howMuchToBuy} million.\nWe appreciate your business and look forward to sending you beyond the stars!");
                        }
                        if (howMuchToBuy > 5)
                        {
                            Console.WriteLine("Calculating your total...\n\n");
                            Console.WriteLine($"For {(float)howMuchToBuy} SVI TITAN SMs, your total is ${sixOrMoreTitanSms * howMuchToBuy} million.\nWe appreciate your business and look forward to sending you beyond the stars!");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Thank you for visiting Space Voyagers Inc. Safe travels!");
                        break;
                }
            }
            while (choice != 3);
        }
    }
}