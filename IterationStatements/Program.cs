using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0 - DONE
            int x = 0;


            // Create a do-while loop - DONE
            do
            {
                x++;
                // Increment your variable by 1 - DONE

                // Then add your variable to "numbers" - DONE
                numbers.Add(x);
            }
            // While your variable is less than 100 - DONE
            while (x < 100);


            // Create a while loop - DONE
            while (x < 200)
            // While your variable is less than 200 - DONE
            {
                x++;
                // Increment your variable by 1 - DONE
                // Then add your variable to "numbers" - DONE
                numbers.Add(x);
            }

            Console.WriteLine("Increase:");

            foreach (int y in numbers)
            // Create a foreach loop
            // Write your variable to the console - DONE
            {
                Console.WriteLine($"{y}");
                Console.WriteLine("Decrease:");
            }

            for (int i = 199; i <= (numbers.Count) && i >= 0; i--)
            // Create a for loop - DONE
            // in your initializer set the value of i to 199 - DONE
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" (numbers.Count) - DONE
            // and as long as i is greater than or equal to 0 - DONE
            // Decrement i by 1 - DONE
            {
                Console.WriteLine($"{numbers[i]}");
                // Write to the console "numbers" at index i - DONE
            }
        }
    }
}
