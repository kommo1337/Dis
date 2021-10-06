using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {           
            {
                double dis;
                double a = 3;
                double b = 5;
                double c = 2;
                double x1;
                double x2;
                dis = (b * b) - (4 * a * c);
                if (dis < 0)
                {
                    Console.WriteLine("Нет решения");

                }
                else if (dis == 0)
                {
                    x1 = -b / 2 * a;
                }
                else
                {
                    x1 = (-b - Math.Sqrt(dis)) / 2 * a;
                    x2 = (-b + Math.Sqrt(dis)) / 2 * a;
                    Console.WriteLine(x1);
                    Console.WriteLine(x2);
                }

            }
        }
    }
}
    