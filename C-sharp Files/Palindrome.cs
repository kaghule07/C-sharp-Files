/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Files
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {

            int i, rem;
            int temp = 0, sum = 0;

            for (i = 100; i <= 500; i++)
            {
                temp = i;
                sum = 0;
                while (temp != 0)
                {
                    rem = temp % 10;
                    temp = temp / 10;
                    sum = sum * 10 + rem;
                }
                if (i == sum)
                    Console.WriteLine($"Palindrome Numbers between 100 to 500 is {i}"); 
            }

        }
    }
}
*/