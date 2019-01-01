using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
          1)
            for (int i = 10; i <= 100; i = i + 10)  
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
          2)
            for (int i = 100; i >= 1; i = i - 1) 
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
          3)
            int a;
            Console.Write("enter 2 diget number: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 9 && a < 100)
            {
                Console.Write("asarot: ");
                Console.WriteLine(a / 10);
                Console.Write("ahadot: ");
                Console.WriteLine(a % 10);
                if (a / 10 > a % 10)
                {
                    Console.WriteLine("asarot is bigger then ahadot");
                }
                else
                {
                    if (a / 10 != a % 10)
                    {
                        Console.WriteLine("ahadot is bigger then asarot");
                    }
                    else
                    {
                        Console.WriteLine("ahadot equels asarot");
                    }
                }
            }
            else
            {
                Console.WriteLine("this is not 2 diget number!");
            }
            Console.ReadLine();
          4)
            int i=2;
            for (int a = 2; a <= 100; a++) 
            {
                while (a % i != 0)
                {
                    i++;
                }
                if (a == i)
                {
                    Console.WriteLine(a);
                }
                i = 2;
            }
            Console.ReadLine();
          5)
            int x,a,b,c,d,e,f,g,h;
            Console.Write("enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x / 200 > 0)
            {
                a = x / 200;
                x = x - (a * 200);
                Console.WriteLine("there is {0} bill of 200",a);
            }
            if (x / 100 > 0) 
            {
                b = x / 100;
                x = x - (b * 100);
                Console.WriteLine("there is {0} bill of 100", b);
            }
            if (x / 50 > 0)
            {
                c = x / 50;
                x = x - (c * 50);
                Console.WriteLine("there is {0} bills of 50", c);
            }
            if (x / 20 > 0)
            {
                d = x / 20;
                x = x - (d * 20);
                Console.WriteLine("there is {0} bills of 20", d);
            }
            if (x / 10 > 0)
            {
                e = x / 10;
                x = x - (e * 10);
                Console.WriteLine("there is {0} coins of 10", e);
            }
            if (x / 5 > 0)
            {
                f = x / 5;
                x = x - (f * 5);
                Console.WriteLine("there is {0} coins of 5", f);
            }
            if (x / 2 > 0)
            {
                g = x / 2;
                x = x - (g * 2);
                Console.WriteLine("there is {0} coins of 2", g);
            }
            if (x / 1 > 0)
            {
                h = x;
                Console.WriteLine("there is {0} coins of 1", h);
            }
            Console.ReadLine();
          6)
            int x, j = 1;
            Console.Write("enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i % 10 != x+1; i = i * 10 + j)
            {
                j++;
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */
        }
    }
}
