using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecutivePrime
{
    class ConsecutivePrime
    {
        bool isPrime(int num)
        {
            
            if (num % 2 == 0)
                return false;
            for (int i = 3; i < num / 2; i = i + 2)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int input_number;
            int Sum = 2;
            int Count = 0;
            Console.WriteLine("enter number:");
            input_number = int.Parse(Console.ReadLine());
            ConsecutivePrime obj = new ConsecutivePrime();
            for (int j = 3; j < input_number; j++)
            {
                if (obj.isPrime(j))
                {
                    Sum += j;
                    if (obj.isPrime(Sum) && Sum < input_number)
                    {
                        Console.WriteLine(Sum);
                        Count++;
                    }

                }
            }
            Console.WriteLine("total="+Count);
            Console.ReadKey();
        }
    }
}
