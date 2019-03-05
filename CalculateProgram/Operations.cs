using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateProgram
{
    class Operations
    {
        double a, b, result;

        public void enterNumbers()
        {
            while (true)
            {
                try
            {
                    Console.Write("Enter First number: ");
                    a = Double.Parse(Console.ReadLine());
                    break;
            }
            catch (System.FormatException e1)
            {
                Console.WriteLine("please enter number again you have an exception ");
                continue;
            }
        }
            while (true)
            {
                try
                {
                    Console.Write("Enter Second number: ");
                    b = Double.Parse(Console.ReadLine());
                    break;

                }
                catch (System.FormatException e2)
                {
                    Console.WriteLine("please enter number again you have an exception ");
                    continue;
                }
            }
        }
        public void operationToPerform()
        {
            Console.Write("Select operation to perform (+, -, *, /, % ) :  ");

            string oper = Console.ReadLine();

            switch (oper)
            {
                case "+":
                    result = a + b;
                    Console.WriteLine("Result: " + result);
                    break;

                case "-":
                    result = a - b;
                    Console.WriteLine("Result: " + result);
                    break;

                case "*":
                    result = a * b;
                    Console.WriteLine("Result: " + result);
                    break;

                case "/":
                    result = a / b;
                    Console.WriteLine("Result: " + result);
                    break;

                case "%":
                    result = a % b;
                    Console.WriteLine("Result: " + result);
                    break;

                default:
                    Console.WriteLine("Invalid Operator ");
                    break;
            }
            {
                Console.ReadLine();
            }

        }
        public void chooseToContinue()
        {
            try
            {

                while (true)
                {
                    Console.WriteLine("Do you wish to continue(Y/N): ");
                    String cont = Console.ReadLine();   
                 
                    if (cont.Equals("Y", StringComparison.OrdinalIgnoreCase))
                    {
                        try
                        {
                            enterNumbers();
                            operationToPerform();
                            continue;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("you have an exception: " + e);
                        }
                    }
                    else if (cont.Equals("N", StringComparison.OrdinalIgnoreCase)) 
                    {
                        break;
                    }
                }
                Console.WriteLine("Thank you, have a nice day");
            }
            catch (Exception e)
            {
                Console.WriteLine("e: " + e);

            }
        }
    }
}
