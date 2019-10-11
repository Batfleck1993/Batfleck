using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int a;
            Console.Write("Input a=");
            a = int.Parse(Console.ReadLine());

            int b;
            Console.Write("Input b=");
            b = int.Parse(Console.ReadLine());

            int tmp;



            tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine();

            Console.WriteLine("Output a=" + a);
            Console.WriteLine("Output b=" + b);
            Console.ReadLine();
        }
    }
}

        




