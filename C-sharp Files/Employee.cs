/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Files
{
    public class Employee
    {
        protected int eid;
        protected string name;
        protected double bs, hra, da, pf, gross;

        public Employee()
        {
            eid = 0;
            name = " ";
            bs = 0.0;
        }
        public Employee(int id, string nm, double basic)
        {
            eid = id;
            name = nm;
            bs = basic;
        }
        public virtual void CalculateSalary()
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;
            gross = (bs + hra + da) - pf;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Employee Gross salary is {gross}");
        }
    }
    public class SalesManager : Employee
    {
        private double ta, bonus;
        public SalesManager() : base()// calls the non parametric constructor of parent class
        {
            ta = 0.0;
            bonus = 0.0;
        }

        // pass paramters to base keyword -> it call the parent class parametric constructor
        public SalesManager(int id, string nm, double bs, double t, double b) : base(id, nm, bs)
        {
            ta = t;
            bonus = b;
        }
        public override void CalculateSalary()
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;
            gross = (bs + hra + da + ta + bonus) - pf;
        }
        public override void Print()
        {
            Console.WriteLine($"Sales manager Gross salary is {gross}");
        }
    }
    static void Main(string[] args)
    {
        SalesManager sm = new SalesManager(101, "tushar", 23000, 1000, 2000);
        sm.CalculateSalary(); // run time 
        sm.Print();

        Employee emp = new Employee(102, "kishor", 22000);
        emp.CalculateSalary();
        emp.Print();
    }// entry point of pro
}
*/


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public enum dept { male, female, designation };

    public class Employee
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[5]
            {
                 new Employee{Id=1,Name="Abhijeet",Salary=35000},
                 new Employee{Id=2,Name="Kunal",Salary=55000},
                 new Employee{Id=3,Name="Akash",Salary=35000},
                 new Employee{Id=4,Name="Kalpesh",Salary=45000},
                 new Employee{Id=5,Name="Pranav",Salary=25000},
            };
            foreach (Employee e in emp)
            {
                Console.WriteLine(e);
            }
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Employee Id :{Id} Employee name :{Name} Employee Salary :{Salary}";
        }
    }
}

*/




