using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingIntApplication
{
    class AddingInt
    {
        static void Main(string[] args)
        {/* enter the two digits*/
            Console.WriteLine("Enter num1");
            string num1=Console.ReadLine();
            Console.WriteLine("Enter num2");
            string num2= Console.ReadLine();
            //find the smallest and largest number
            //int min = (num1.Length < num2.Length ? num1.Length : num2.Length);
            int max = (num1.Length < num2.Length ? num2.Length : num1.Length);
            int[] n1 = new int[max];
            int[] n2 = new int[max];
            for(int i = 0 ; i < num1.Length ; i++)
            {
                n1[i] = num1[num1.Length - 1 - i] - 48;
            }
            Console.WriteLine("num1="+num1);
            for (int i = 0; i < num2.Length; i++)
            {
                n2[i] = num2[num2.Length - 1 - i] - 48;
            }
            Console.WriteLine("num2="+num2);
            int carry = 0;
            int[] sum = new int[max + 1];
            int k = 0;
            for( k = 0 ;k < max; k++)
            {
                sum[k] = (n1[k] + n2[k] + carry) % 10;

                if ((n1[k] + n2[k] + carry) >= 10)
                    carry = 1;
                else
                    carry = 0;

            }
            sum[max] = carry;
            

            for(int j=max; j>=0; --j)
            {
                Console.Write(sum[j]);

            }


            Console.ReadKey();

        }
    }
}
