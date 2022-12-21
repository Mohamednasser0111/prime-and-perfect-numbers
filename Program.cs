using System;
namespace hello
{
    class prime
    {
        static void Main(String[] args)
        {
            Console.WriteLine("enter num1");
            double num1 = double.Parse(Console.ReadLine());


            Console.WriteLine("enter num2");
            double num2 = double.Parse(Console.ReadLine());
           
            Console.WriteLine("the perfect numbers :");
            for (double i = num1; i < num2; i++)
            {

              
                double result = 0;
                for (int j = 1; j < i ; j++)
                {
             

                    if (i % j == 0)
                    {

                        result += j;

                    }

                }
                if ( result== i)

                    Console.WriteLine(i);
            }

        }


    }


}