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
            var prime_factor = new List<Int64>();
            for (Int64 i = num; i > 0; i--)
            {
                decimal remainder = Convert.ToDecimal(num) / Convert.ToDecimal(i);
                Int64 n = Convert.ToInt64(remainder);
                bool is_a_prime = true;
                var factor = new List<Int64>();
                if (remainder % 1 == 0 && n > 1)
                {
                    for (Int64 k = n; k > 0; k--)
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
            Int64[] primes = prime_factor.ToArray();
            Int64 largest_prime = primes.Max();
            Console.WriteLine($"The largest prime factor is {largest_prime}.");
        }
    }
}
