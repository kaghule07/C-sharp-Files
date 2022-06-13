/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Files
{
    internal class Assignment5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Marks of Five Subject");

            Console.WriteLine("Enter The Marks Obtained in English: ");
            Int32 eng = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Marks Obtained in Math: ");
            Int32 math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Marks Obtained in Physics: ");
            Int32 phy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Marks Obtained in Chemistry: ");
            Int32 chem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Marks Obtained in Biology: ");
            Int32 bio = Convert.ToInt32(Console.ReadLine());

            int total = eng + phy + math + chem + bio;
            double percentage = (total / 500.0) * 100;



            if (percentage >= 90)
            {
                Console.WriteLine("Percentage: " + percentage + ",Grade : A");
            }
            else if (percentage >= 80)
            {
                Console.WriteLine("Percentage: " + percentage + ",Grade : B");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("Percentage: " + percentage + ",Grade : C");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Percentage: " + percentage + ",Grade : D");
            }
            else if (percentage >= 40)
            {
                Console.WriteLine("Percentage: " + percentage + ",Grade : E");
            }
            else if (percentage < 40)
            {
                Console.WriteLine("Percentage: " + percentage + ",Grade : F");
            }
        }
        
    }
}
*/