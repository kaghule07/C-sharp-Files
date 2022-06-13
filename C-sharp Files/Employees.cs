/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Files
{
    public class Employees
    {
        
        protected int id;
        protected string name;  
        protected int salary;

        public Employees()
        {
            id = 0;
            name = "";
            salary = 0; 
        }
        public Employees(int empid, string empname, int empsalary)
        {
            id = empid; 
            name = empname; 
            salary = empsalary; 
        }
        public void display()
        {
            Console.WriteLine($"Employee id: {id},Employee Name: {name},Employee Salary: {salary}"); ;
        }
        static void Main (string[] args)
        {
            Employees em = new Employees();
            em.id = 3247;
            em.name = "Kushal";
            em.salary = 45475;
            em.display();
        }
    }

}
*/