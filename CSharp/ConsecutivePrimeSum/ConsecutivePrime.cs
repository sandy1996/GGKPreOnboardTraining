using System;

namespace ConsecutivePrime
{
    class ConsecutivePrime
    {
        bool isPrime(int num)
        {
            int count = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    count++;
                    if (c == 2)
                    {
                        return true;

                    }
                }
            }
            return false;
        }
 
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int Number;
            Number = Console.Read();
            ConsecutivePrime obj = new ConsecutivePrime();
            List<int> numberslist = new List<int>();
            for (int i = 0; i <= Number; i++)
            {
                if (obj.isPrime(i))
                    numbers.Add(i);
            }
            int sum = 2;
            int count = -1;
            foreach(int num in numberslist)
            {
                sum = sum + num;
                if(sum<Number && obj.isPrime(sum))
                {
                    count++;
                }

            }

            Console.WriteLine(count);

        }

    }
}