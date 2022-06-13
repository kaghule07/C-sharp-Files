/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Files
{
    internal class Assignment3
    {
        static void main(string[] args)
        {
            Console.WriteLine("Enter Any Number: ");
            Int32 num = Convert.ToInt32(Console.ReadLine());
            int rem, rev = 0;
            while (num >= 1)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse Number is " + rev);
        }
    }
}
*/