using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            bool k = true;
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (s[i] != s[j])
                {
                    k = false;
                    break;
                }
                k = true;
            }
            if (k == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}