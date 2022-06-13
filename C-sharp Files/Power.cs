/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Files
{
    internal class Power
    {
        static void Main(string [] args)
        {
            *//*int exp, bas, res=1;
            Console.WriteLine("Enter a base: ");
            bas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a exponent: ");
            exp = Convert.ToInt32(Console.ReadLine());
            while(exp!=0)
            {
                res *= bas;
                exp--;
            }
            Console.WriteLine(res);*//*

            int[,] arr = new int[4, 5];
            Console.WriteLine("Enter The Elements in an array: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine(arr[i, j]);
                }
            }

        }



    }
}
*/