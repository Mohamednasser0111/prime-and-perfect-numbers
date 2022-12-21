using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter num1");
            int num1 = int.Parse(Console.ReadLine());


            Console.WriteLine("enter num2");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("the prime numbers :");
            for (int i = num1; i < num2; i++)
            {
                int k = 0;
                for (int j = 2; j < i; j++)
                {

                    if (i % j == 0)
                    {
                        k++;
                        break;

                    }

                }
                if (k == 0 && i != 1)

                    Console.WriteLine(i);
            }
        }
    }
}
