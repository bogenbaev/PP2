using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        //  create bool function   
        public static bool f(int n)
        {
            // If number equal to 1 or less this command give us false //   
            if (n <= 1) return false;
            else
            // otherwise create k variable that equal to true //
            {
                bool k = true;
                
           

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        k = false;
                        break;
                    }
                }
                //return connected with main
                return k;
            }
        }
        static void Main(string[] args)
        {
            // write integer by int.Parse
            int n = int.Parse(Console.ReadLine());
            // empty string 
            string s = Console.ReadLine();
            // divide seperately
            string[] a = s.Split();
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(a[i]);
            }
            // create counter for find how many primes
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                // number is not prime
                if (f(b[i]) == false) b[i] = 0;
                else cnt++;
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < n; i++)
            {
                // number prime write 
                if (b[i] != 0) Console.Write(b[i] + " ");
            }
        }
    }
}