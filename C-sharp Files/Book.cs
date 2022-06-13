/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Files
{

    public class Book
    {
        public int Id { get; set; }
        public string bookname { get; set; }
        public string authorname { get; set; }
        public int price { get; set; }

        public override string ToString()
        {
            return $"BookId:{Id} BookName: {bookname} AuthorName:{authorname} Price:{price}";
        }
        static void Main(string[] args)
        {
            Book bk = new Book();
            bk.Id = 24546;
            bk.bookname = "C#";
            bk.authorname = "abc";
            bk.price = 229;
            Console.WriteLine(bk);

        }
    }
}*//*






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{

    public class Book
    {
        static void Main(string[] args)
        {
            Book[] bk = new Book[5]
            {
                 new Book { Id = 301, Title = "ASP.NET", AuthorName = "Tushar", Price = 507 },
                 new Book { Id = 302, Title = "Java", AuthorName = "Kushal", Price = 508 },
                 new Book { Id = 303, Title = "C Lang", AuthorName = "Abhijeet", Price = 357 },
                 new Book { Id = 304, Title = "Python", AuthorName = "Kalpesh", Price = 510 },
                 new Book { Id = 305, Title = "SQL", AuthorName = "Pranav", Price = 357 },
            };
            foreach (var b in bk)
            {

                Console.WriteLine(b);
            }
            Console.WriteLine("Books Price greater than 500 ");
            for (int i = 0; i < bk.Length; i++)
            {
                if (bk[i].Price >= 500)
                {
                    Console.WriteLine(bk[i]);
                }

            }

        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return $"Book ID:{Id},Tittle:{Title},AuthorName{AuthorName},Price: {Price}";
        }
    }
}


*/