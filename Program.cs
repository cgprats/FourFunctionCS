using System;

namespace FourFunctionCS {
    class Program {
        static void Main(string[] args)
        {
            //Declare Initial Variables
            int operation = default;
            double[] values = new double[2];
            double result = default;
            do
            {
                //Ask User for Operation
                Backend.DisplayFFMenu();
                Console.Write("Select an Operation: ");
                string input = Console.ReadLine();
                operation = Convert.ToInt32(input);

                //Set the Values if Needed
                if (operation >= 1 && operation <= 4)
                {
                    values = Backend.SetValues();
                }

                //Perform Operation
                switch (operation)
                {
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    case 1:
                        result = Operations.Addition(values[0], values[1]);
                        break;
                    case 2:
                        result = Operations.Subtraction(values[0], values[1]);
                        break;
                    case 3:
                        result = Operations.Multiplication(values[0], values[1]);
                        break;
                    case 4:
                        result = Operations.Division(values[0], values[1]);
                        break;
                    default:
                        Console.WriteLine("Please Select a Valid Operation");
                        break;
                }

                //Display Result if Needed
                if (operation >= 1 && operation <= 4)
                {
                    Console.WriteLine("Result: " + result);
                }
            } while (operation != 0);
        }
    }
}