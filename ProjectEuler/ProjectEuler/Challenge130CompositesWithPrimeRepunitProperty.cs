using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Challenge130CompositesWithPrimeRepunitProperty
    {

        //static void Main(String[] args)
        //{
        //    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        //    string[] consoleInput = Console.ReadLine().Split(' ');

        //    int L = int.Parse(consoleInput[0]);
        //    int R = int.Parse(consoleInput[1]);


        //    while (L <= R)
        //    {

        //        if (IsPrime(L))
        //        {
        //            L++;
        //            continue;
        //        }

        //        int a = A(L);

        //        if (a != 0 && ((L - 1) % a == 0))
        //        {
        //            Console.WriteLine(L);
        //        }

        //        L++;
        //    }

        //}

        public static List<int> compositeInterval(int L, int R)
        {
            List<int> returnValue = new List<int>();

            L = L < 91 ? 91 : (L % 2 == 0 ? L + 1 : L);


            while (L <= R)
            {

                if (IsPrime(L))
                {
                    L += 2;
                    //L++;
                    continue;
                }

                int a = A(L);

                if (a != 0 && ((L - 1) % a == 0))
                {
                    returnValue.Add(L);
                }

                L += 2;
                //L++;
            }

            return returnValue;
        }
        
        static int A(int n)
        {

            if (GCD(n, 10) != 1) return 0;

            int x = 1;
            int k = 1;

            while (x != 0)
            {
                x = (x * 10 + 1) % n;
                k++;
            }

            return k;
        }

        static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        //public static bool IsPrime(int candidate)
        //{
        //    // Test whether the parameter is a prime number.
        //    if ((candidate & 1) == 0)
        //    {
        //        if (candidate == 2)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    // Note:
        //    // ... This version was changed to test the square.
        //    // ... Original version tested against the square root.
        //    // ... Also we exclude 1 at the end.
        //    for (int i = 3; (i * i) <= candidate; i += 2)
        //    {
        //        if ((candidate % i) == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return candidate != 1;
        //}

        //static bool IsPrime(long n)
        //{
        //    if (n <= 3) return n > 1;
        //    if (n % 2 == 0 || n % 3 == 0) return false;
        //    for (int i = 5; i * i <= n; i += 6)
        //    {
        //        if (n % i == 0 || n % (i + 2) == 0) return false;
        //    }
        //    return true;
        //}

        static bool IsPrime(int n)
        {
            if (n % 3 == 0)
                return false;

            int s = (int)Math.Sqrt(n);
            for (int i = 5; i <= s; i += 6)
            {
                if (n % i == 0)
                    return false;
                if (n % (i + 2) == 0)
                    return false;
            }

            return true;
        }
        
    }
}
