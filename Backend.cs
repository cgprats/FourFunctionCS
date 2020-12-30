using System;

namespace FourFunctionCS
{
    public class Backend
    {
        //Display the Menu Used by the Program
        public static void DisplayFFMenu()
        {
            Console.WriteLine("Available Operations: ");
            Console.WriteLine("\t1. Addition");
            Console.WriteLine("\t2. Subtraction");
            Console.WriteLine("\t3. Multiplication");
            Console.WriteLine("\t4. Division");
            Console.WriteLine("\t0. Exit");
        }

        //Set the Values of Variables
        public static double[] SetValues()
        {
            //Declare Variables
            double[] values = new double[2];

            //Set Value One
            Console.Write("Enter Value One: ");
            string input = Console.ReadLine();
            values[0] = Convert.ToDouble(input);

            //Set Value Two
            Console.Write("Enter Value Two: ");
            input = Console.ReadLine();
            values[1] = Convert.ToDouble(input);

            //Return the Values
            return values;
        }
    }
}