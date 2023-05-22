using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = 40;

        int a = 1;
        int b = 1;

        Console.WriteLine("Перші {0} чисел Фібоначчі:", n);

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a);

            int next = a + b;
            a = b;
            b = next;
        }

        Console.ReadLine();
    }
}

