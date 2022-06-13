using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Files
{
    public class Generic_Class
    {
        class Student
        {
            public delegate void Mydel();
            public class Students
            {
                public event Mydel Fail;
                public event Mydel Distinction;

                public void Acceptmarks(int marks)
                {
                    if (marks < 40)
                        Fail();

                    else
                        Distinction();

                    Console.WriteLine($"Yours score is  is {marks}");
                }
            }
            static void FailMsg()
            {
                Console.WriteLine("You are fail");
            }
            static void DistinctionMsg()
            {
                Console.WriteLine("You are passed with distinction");
            }
            static void Main(string[] args)
            {
                Students s1 = new Students();
                s1.Fail += new Mydel(FailMsg);
                s1.Distinction += new Mydel(DistinctionMsg);
                s1.Acceptmarks(64);

            }
        }
    }
}
