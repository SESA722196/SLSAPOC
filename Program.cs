﻿class Calculator
{
    public static double DoOperation(double n1, double n2, string op)
    {
        double result = double.NaN;

        switch (op)
        {
            case "a":
                result = n1 + n2;
                break;
            case "s":
                result = n1 - n2;
                break;
            case "m":
                result = n1 * n2;
                break;
            case "d":
                if (n2 != 0)
                {
                    result = n1 / n2;
                }
                break;
            default:
                break;
        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;

        Console.WriteLine("calc test\r");
        Console.WriteLine("---------\n");

        while(!endApp)
        {
            string nInput1 = "";
            string nInput2 = "";
            double result = 0;

            Console.WriteLine("type number");
            nInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(nInput1, out cleanNum1))
            {
                Console.Write("not valid");
                nInput1 = Console.ReadLine();
            }

            Console.Write("new num");
            nInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while(!double.TryParse(nInput2, out cleanNum2))
            {
                Console.Write("not valid");
                nInput2 = Console.ReadLine();
            }

            Console.WriteLine("choose operation:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("sel? ");

            string op = Console.ReadLine();

            try
            {
                result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("This operation is invalid");
                }
                else Console.WriteLine("Results: {0:0.##}\n", result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("----------------------------------\n");

            Console.Write("Press 'n' and Enter to close the app, or any other key");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n");
        }
        return;
    }
}