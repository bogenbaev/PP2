using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] a = s.Split();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(a[i] + ' ');
                }

            }
        }
    }
