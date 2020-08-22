using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Int64 num = Convert.ToInt64(Console.ReadLine());
            var prime_factor = new List<int>();
            for (Int64 i = num; i > 0; i--)
            {
                decimal remainder = Convert.ToDecimal(num) / Convert.ToDecimal(i);
                int n = Convert.ToInt32(remainder);
                bool is_a_prime = true;
                var factor = new List<int>();
                if (remainder % 1 == 0 && n > 1)
                {
                    for (int k = n; k > 0; k--)
                    { 
                        decimal remain = remainder % Convert.ToDecimal(k);
                        if (remain == 0)
                        {
                            factor.Add(k);
                            int leng = factor.Count;
                            if (leng >= 3)
                            {
                                is_a_prime = false;
                                break;
                            }
                        }
                    }
                    if (is_a_prime)
                    {
                        prime_factor.Add(n);
                    }
                }
            }
            int[] primes = prime_factor.ToArray();
            int largest_prime = primes.Max();
            Console.WriteLine($"The largest prime factor is {largest_prime}.");
        }
    }
}
