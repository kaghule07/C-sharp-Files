/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Files
{
    public class Array
    {
        static void Main(string [] args)
        {
            *//*int[,] list = new int[3, 2];
            Console.WriteLine("Enter The Elements in an array: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    list[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(list[i, j]);
                }
                Console.WriteLine();
            }*/

/*int[,] mat1 = new int[3, 3];
int[,] mat2 = new int[3, 3];
int[,] add= new int[3, 3];
Console.WriteLine("Enter first Matrix of Elements");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        mat1[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("Enter Second Matrix of Elements");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        mat2[i,j]=Convert.ToInt32(Console.ReadLine());  
    }
}
Console.WriteLine("Result: ");
for(int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        add[i, j] = mat1[i, j] + mat2[i, j];
        Console.Write($"{add[i,j]} ");
    }
    Console.WriteLine();
}*//*

int[,] mat1 = new int[2, 2];
int[,] mat2 = new int[2, 2];
int[,] add = new int[2, 2]; 
Console.WriteLine("Enter first Matrix of Elements");
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        mat1[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("Enter Second Matrix of Elements");
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        mat2[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("Result: ");
for(int i = 0; i < 2; i++)
{
    for(int j = 0; j < 2; j++)
    {
        add[i, j] = mat1[i, j] + mat2[i, j];
        Console.Write(" "+add[i,j]);
    }
    Console.WriteLine();
}
}
}   
}
*/