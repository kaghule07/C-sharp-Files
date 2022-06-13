/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Files
{
    public class Product
    { 
         public int Id { get; set; }
         public string Name { get; set; }
         public double Price { get; set; }

        public override string ToString()
        {
            return $"product Id :{Id} product name :{Name} Price :{Price}";
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
    public class Product
    { 
         public int Id { get; set; }
         public string Name { get; set; }
         public double Price { get; set; }

        public override string ToString()
        {
            return $"product Id :{Id} product name :{Name} Price :{Price}";
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
    public class Product
    {
        private int prid;
        private string prname;
        private double prprice;
        public  Product(int id)
        {
           this.prid= id;   
        }
        public Product(string name)
        {
            this.prname = name;
        }
        public Product(double price)
        {
            this.prprice = price;   
        }
        public override string ToString()
        {
            return $"product Id :{prid} product name :{prname} Price :{prprice}";
        }
        static void Main(string[] args)
        {
            *//*Product prt = new Product(451,"C#",4548);
            Console.WriteLine(prt);*//*
            Product prod = new Product(45);
            Product pr = new Product("Face Wash");
            Product prc = new Product(299);
            Console.WriteLine(prod);
            Console.WriteLine(pr);
            Console.WriteLine(prc);
        }
    }
}
*/


/*using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public class Product
    {
        
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(int Code, string Name, int Price)
        {
            this.Code = Code;
            this.Name = Name;
            this.Price = Price;
        }
        public override string ToString()
        {
            return $"product Id :{Code} product name :{Name} Price :{Price}";
        }
        static void Main(string [] args)
        {
            ArrayList list1 = new ArrayList() {

                new Product(56,"kg",565),
                new Product(59,"kg",566)
            };
            foreach ( Product p  in list1 )
            {
                Console.WriteLine(p);
            }
        }
    }
}*/


/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject

    public class dep

    {
        public int id { get; set; }
        public string name { get; set; }
        public string department { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<dep> list = new List<dep>()
            {
                new dep { id = 101, name = "Rakesh", department = "Pune" },
                new dep { id = 102, name = "Prakash", department = "Nagpur" },
                new dep { id = 103, name = "Shailesh", department = "Amravati" }
            };
            foreach (dep s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
    
}
*/