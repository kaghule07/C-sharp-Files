

/*class Employee
{
    private static int count;
    private int id;
    private string name;
    private double salary;

    public Employee(string name,double salary)
    {
        count++;
        id = count;
        this.name = name;
        this.salary = salary;   
    }
    public override string ToString()
    {
        return $"{id} {name} {salary}";
    }

    public static void ShowCount()
    {
        Console.WriteLine($"Total Count {count}");
    }
}*/

/*namespace C_sharp_Files
{
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Salary { get; set; }

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

                Console.WriteLine($"{e.Id},{e.Name},{e.Salary}");
            }
        }
        }
}

*/

/*namespace C_sharp_Files
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
    class P
    {
        static void Main(string[] args)
        {
            Product[] p = new Product[5]
            {
                new Product{Id=101,Name="HP",    Price=29999},
                new Product{Id=101,Name="DALE",  Price=3999},
                new Product{Id=101,Name="APPLE", Price=12999},
                new Product{Id=101,Name="LENOVO",Price=69999},
                new Product{Id=101,Name="MSI",   Price=79999}
            };
            foreach (Product py in p)
            {
                Console.WriteLine($"{py.Id},{py.Name},{py.Price}");
            }
        }
    }

}*/

/*class Array
{
    static void Main(string[] args)
    {
        int[,] arr = new int[4,3]
        {
            {9,5,3},
            {4,7,1},
            {9,3,4},
            {4,8,3}
        };
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j <3; j++)
            {
                Console.Write(arr[i,j]+ " ");
            }
            Console.WriteLine();
        }
    }
}*/
//using System;
/*class jagged
{
    static void Main(string[] args)
    {
        int[][] arr = new int[3][]
            {
                new int[]{1,7,3},
                new int[]{30,20},
                new int[]{1,4,3,4}

            };
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j] + "  ");
            }
            Console.WriteLine();
        }

    }
}*/


/*class dic
{
    static void Main(string[] args)
    {
        Dictionary <int,string> dic =new Dictionary<int,string>();
        dic.Add(91, "IND");
        dic.Add(67, "AUS");
        dic.Add(45, "US");
        
        foreach(KeyValuePair<int,string> k in dic)
        {
            Console.WriteLine($"{k.Key} {k.Value}" );
        }
    }
}*/


/*namespace C_sharp_Files
{
    public class Test<T>
    {
        T element;
        public void Add(T element)
        { this.element = element; }
        public T Display()
        { return this.element; }
    }

    public class Department
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double salary { get; set; }

        public override string ToString()
        {
            return $"{Id},{Name},{salary}";
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Test<int> obj1 = new Test<int>();
            obj1.Add(7);
            Console.WriteLine(obj1.Display());

            Test<string> obj2 = new Test<string>();
            obj2.Add("Dhoni");
            Console.WriteLine(obj2.Display());

            Test<Department> obj3 = new Test<Department>();
            obj3.Add(new Department { Id = 707, Name = "Dhoni", salary = 700000 });
            Console.WriteLine(obj3.Display());
        }
    }

}*/

/*class Swap
{
    static void swap<T>(T num1, T num2)
    {
        T temp;
        temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine($"After Swap {num1} {num2}");
    }

    static void Main(string[] args)
    {
        Swap <int>= (10,20);

    }
}*/

/*class StrManipulation
{

    static void Main(string[] args)
    {
        StrManipulation str= new StrManipulation();
        Mydel obj1 = new MyDel(str.Lowercase);
        obj1 += new Mydel(str.Uppercase);

        Delegate[] list=
    }
}*/

/*namespace C_sharp_Files
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
 
}*/


namespace C_sharp_Files
{
    class Program
    {
        public delegate void mydel();
        public class Bank
        {
            public event mydel debit;
            public event mydel credit;
            public int bal = 5000;
            public void Debit(int deb)
            {
                if (bal == 0)
                    Zero();

                else if (deb > bal)
                    Insufficient();
                bal = bal - deb;
                Console.WriteLine($"Total Balance is {bal}");
            }

            public void Credit(int credit)
            {
                bal += credit;
                Console.WriteLine($"Total Balance is {bal}");
            }
        }
        static void Zero()
        {
            Console.WriteLine("Balance is zero");
        }
        static void Insufficient()
        {
            Console.WriteLine("Balance is insufficeint");
        }
        static void Main(string[] args)
        {
            Bank bn = new Bank();
            bn.debit += new mydel(Zero);
            bn.debit += new mydel(Insufficient);
            bn.Debit(500);
        }
    }
}