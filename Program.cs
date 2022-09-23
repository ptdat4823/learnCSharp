using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //decimal a = 10.9m;
            //double a = 10.9;
            //Console.WriteLine(a);

            //int k = 0;
            //switch (k)
            //{
            //    case 0:
            //        Console.WriteLine("Moi ban nhap nam: " + Console.ReadLine());
            //        break;
            //    case 1:
            //        Console.WriteLine("1");
            //        break;
            //    default:
            //        Console.WriteLine("default");
            //        break;
            //}
            //Console.WriteLine("Nhap nam: ");
            //int year = Int16.Parse(Console.ReadLine());
            //Console.WriteLine(year);
            int[] mang = new int[4] { 0, 1, 2, 3};
            for(int i = 0; i<3; i++)
            {
                Console.WriteLine(mang[i]);
            }
        }
    }
}
