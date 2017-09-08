using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecutivePrime
{
    class ConsecutivePrime
    {
        public bool Isprime(int a)
        {
            int k = 0;
            for (int i = 1; i < a; ++i)
            {
                if (a % i == 0)
                {
                    ++k;
                }
            }
            if (k > 1)
            {
                return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int number,count=0,sum,sc=0;
            number = Console.Read();
            ConsecutivePrime obj = new ConsecutivePrime();
            List<int> primelist = new List<int>();
            List<int> s = new List<int>();
            for (int i = 3; i <= number; ++i)
            {
                if (obj.Isprime(i))
                {
                    primelist.Add(i);
                    count++;
                }
            }
            /*for(int k=0;k<count;k++)
            {
                for (int l = 1; l < count - k; ++l)
                {

                }
            }
            */

            // Console.WriteLine(c);
            for (int k = 1; k < count; ++k)
            {

                for (int l = 1; l < count - k; ++l)
                {
                    sum = 0;

                    for (int i = l, m = 0; m <= k; ++m, ++i)

                    {




                        sum = sum + primelist[i];
                        if (sum > number) { break; }
                    }

                    if (obj.Isprime(sum) && sum < number)
                    {

                        sc++;
                        s.Add(sum);
                    }
                }
            }
            Console.WriteLine("\n{0}", s.Count);
            Console.ReadKey();

        }

    }
}
