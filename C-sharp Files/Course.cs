/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Files
{
    public class Course
    {
        static void Main (string[] args)
        {
        Course[] cr = new Course[5]
        {

            new Course{Id=701,Name="I.T",Fees=52000},
            new Course {Id=702,Name="C.S",Fees=69000},
            new Course {Id=703,Name="C.T",Fees=52000},
            new Course {Id=704,Name="I.O.T",Fees=79000},
            new Course {Id=705,Name="A.I",Fees=89000},

        };
            foreach (Course c in cr)
            {
                Console.WriteLine(c);
            }

        }
        public int Id { get; set; }

        public string Name { get; set; }
        public int Fees { get; set; }

        public override string ToString()
        {
            return $"Course ID: {Id},Course Name: {Name},Course Fees: {Fees}";
        }
    }
}
*/