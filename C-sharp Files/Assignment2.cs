/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Files
{
    internal class Assignment2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Operator(+, -, *, /)");
            string op = Console.ReadLine();
            Console.WriteLine("Enter First Operand: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter First Operand: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double res;
            switch (op)
            {
                case "+":
                    res = num1 + num2;
                    Console.WriteLine($"Addition : {num1} + {num2} = {res}");
                    break;
                case "-":
                    res = num1 - num2;
                    Console.WriteLine($"Subtraction:  {num1} - {num2} = {res}");
                    break;
                case "*":
                    res = num1 * num2;
                    Console.WriteLine($"Multiplication : {num1} * {num2} = {res}");
                    break;
                case "/":
                    res = num1 / num2;
                    Console.WriteLine($"Division : {num1} / {num2} = {res}");
                    break;
                default:
                    Console.WriteLine("!INVALID OPERAND");
                    break;
            }
        }

    }
}

*/