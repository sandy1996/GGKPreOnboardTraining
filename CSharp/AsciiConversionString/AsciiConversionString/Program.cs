using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiConversionString
{
    class AsciiConversion
    {
        //checking if prime or not
       static Boolean isPrime(int num)
        {
            int count=0;
            for(int i=1; i<=num/2;i++)
            {
                if (num % i == 0)
                    count++;
                if (count > 1)
                    return false;
            }
            if (count == 1)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            string inputString;
            int currentAscii, nextAscii;
            Console.WriteLine("enter string");
            inputString = Console.ReadLine();
            int[] avg_array = new int[inputString.Length - 1];
            //Taking the average of currentAscii and nextAscii
            for(int i=0; i<inputString.Length-1 ;i++)
            {
                currentAscii = (int)inputString[i];
                nextAscii = (int)inputString[i + 1];
                avg_array[i] = (currentAscii + nextAscii) / 2;
            }
            //Prime or not
           // Program obj = new Program();

            for(int i=0;i<avg_array.Length;i++)
            {
                if(AsciiConversion.isPrime(avg_array[i]))
                {
                    avg_array[i] += 1;
                }
            }
            //the final output
            for (int i = 0; i < avg_array.Length; i++)
            {
                Console.Write(Convert.ToChar(avg_array[i]));
            }

            Console.ReadKey();
        }

    }
}
