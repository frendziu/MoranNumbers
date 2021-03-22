using System;

namespace MoranNumbers
{
    class Program
    {

        static string Moran(int n)
        {
            int sum = 0;
            int num = n;
            while(num > 0)
            {
                sum += (num % 10);
                num /= 10;
            }
            if(n%sum ==0 )
            {
                if (CheckIsPrime(n/sum))
                    return "M";
                else
                    return "H";
            }
            else
            {
                return "Neither";
            }

        }

        static bool CheckIsPrime(int n)
        {

            if (n < 1) return false;
            if (n == 2) return true;
            for(int i = 2; i<=n/2; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Moran(132));
            Console.WriteLine(Moran(133));
            Console.WriteLine(Moran(134));
        }
    }
}
