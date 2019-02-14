using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = "[*]";
            // array of strings 
            string[,] a = new string[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // i bigger than j, so when cycle is started from i = 1, j = 0 this condition true for string can move by stairs  
                    if (j <= i) a[i, j] = s;
                    // when that condition is not true instead of string put empty string 
                    else a[i, j] = "";
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
