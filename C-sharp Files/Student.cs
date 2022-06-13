/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Files
{
    public class Student
    {
        private int phy;
        private int chem;
        private int math;
        private int bio;
        private int cs;
        private int totalmarks;
        private int percentage;

        public int Phy
        {
            set { phy = value; }
            get { return phy; }
        }

        public int Chem
        {
            set { chem = value; }
            get { return chem; }
        }

        public int Math
        {
            set { math = value; }
            get { return math; }
        }
        public int Bio
        {
            set { bio = value; }
            get { return bio; }
        }
        public int CS
        {
            set { cs = value; }
            get { return cs; }
        }


        public override string ToString()
        {
            totalmarks = phy + chem + math + cs + bio;
            percentage = totalmarks * 100 / 500;
            return $"Total Marks : {totalmarks} Percentage: {percentage}";
        }
        static void Main(string[] args)
        {
            Student st=new Student();
            st.Phy = 70;
            st.Chem = 67;
            st.Math = 78;
            st.Bio = 89;
            st.CS = 87;
            Console.WriteLine(st);

        }
    }
}
*//*




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public  class Student
    {
        static void Main(string [] args)
        {
            Student[] st = new Student[5]
            {
                new Student { Id = 1, Name = "Abhijeet", Branch = "I.T"},
                new Student{ Id = 2, Name = "Kunal", Branch = "C.S" },
                new Student { Id = 3, Name = "Akash", Branch = "C.T" },
                new Student { Id = 4, Name = "Kalpesh", Branch = "C.S" },
                new Student { Id = 5, Name = "Pranav", Branch = "I.T" },
            };
            foreach (Student s in st)
            {
                Console.WriteLine(s);
            }
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }

        public override string ToString()
        {

            return $"Student Id :{Id} Student Name :{Name} Branch :{Branch}";
        }
    }

}*/
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyFirstProject
{
    public static class Student
    {
        static void Main(string [] args)
        {
            int[] arr = new int[5];

            {
                Console.WriteLine("Enter The Elements into an array: ");
            }
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                int count = 0;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                for (int k = i+1; k < 5; k++)
                {
                    if (arr[i] == arr[k])
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.Write("There Unique Numbers are : " + arr[i]);
                }
                Console.WriteLine();
            }
            
        }

    }


}

*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyFirstProject
{
    public class Student
    {

        public class Student
        {
            public enum dept { male, female, designation };
            private int id;
            private string name;
            private dept d;
            private string gender;
            private string designation;
            public Enumcs(int eid, string ename, dept dep)
            {
                id = eid;
                name = ename;
                d = dep;
            }
            static void Main(string[] args)
            {
                Enumcs e1 = new Enumcs(1, "Test", dept.male);
            }
        }

    }

}*/


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public enum dept { male, female, designation };
    public class Student
    {

          
         private int id;
         private string name;
         private dept d;
         *//*private string gender;
         private string designation;*//*
         public Student(int eid, string ename, dept dep)
         {
              id = eid;
              name = ename;
              d = dep;
         }
        static void Main(string [] args)
        {
            Student e1 = new Student(1, "Test", dept.male);
            Console.WriteLine(e);
        }
    }
    
}*/