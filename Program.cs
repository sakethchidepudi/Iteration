using System;

namespace Iteration_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an Integer value to execute an iterative statement: ");
            try
            {
                int input = int.Parse(Console.ReadLine());

                if (input > 0)
                {
                    Console.WriteLine("Executing a For Loop!");
                    Console.WriteLine("The For Loop will iterate " + input.ToString() + " times.");
                    for (int i = 0; i <= input; i++)
                    {
                        Console.WriteLine("You have "+ i.ToString() + " years of experience");
                    }
                }
                else
                {
                    Console.WriteLine("No Experience");
                }
            } // End of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            } // End of catch
        } // End of Main
    } // End of class
} // End of namespace
