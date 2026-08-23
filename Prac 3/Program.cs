using System;

namespace Practical_3
{
    class HenyExpense
    {
        static void Main()
        {
            double total = 0;

            while (true)
            {
                try
                {
                    Console.Write("Enter Expense Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Category: ");
                    string category = Console.ReadLine();

                    Console.Write("Enter Amount: ");
                    double amount = Convert.ToDouble(Console.ReadLine());

                    if (amount <= 0)
                    {
                        throw new Exception("Amount must be greater than zero.");
                    }

                    total += amount;

                    Console.WriteLine("\nExpense Added Successfully!");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("Expense Name : " + name);
                    Console.WriteLine("Category     : " + category);
                    Console.WriteLine("Amount       : ₹" + amount);
                    Console.WriteLine("Total Expense: ₹" + total);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a valid numeric amount.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                Console.Write("\nDo you want to add another expense? (y/n): ");
                string choice = Console.ReadLine();

                if (choice.ToLower() != "y")
                {
                    break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nThank you for using Expense Tracker!");
            Console.ReadKey();
        }
    }
}