using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220330_3
{
    class Program
    {
        private static bool Prime(int n)
        {
            bool is_prime = true;
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    is_prime = false;
                }
            }
            return is_prime;
            
        }
        static void Main(string[] args)
        {
            bool is_prime = false;
            for (int i = 100; i < 501; i++)
            {
                is_prime = Prime(i);
                if (is_prime == true)
                {
                    Console.WriteLine(i + "是質數");
                }

            }
            Console.ReadLine();
            /*1-500*/
        }
    }
}
