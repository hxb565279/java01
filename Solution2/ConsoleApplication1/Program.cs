using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public void Sort(int x, int y, int z)
        {
            int tmp;
            if (x > y)
            {
                tmp = x; x = y; y = tmp;
            }
            if (x > z)
            {
                tmp = x; x = z; z = tmp;
            }
            if (y > z)
            {
                tmp = y; y = z; z = tmp;
            }
        }
        class MyClass
        {
            static void Main(string[] args)
            {
                Program p = new Program();
                int a, b, c;
                a = 50;
                b = 4;
                c = 55;
                p.Sort(a, b, c);
                Console.WriteLine("a={0},b={1},c={2}",a,b,c);
            }
        }
    }
}