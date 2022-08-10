using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Entre com o número : ");
            int x = int.Parse(Console.ReadLine());

            for(int i = 0; i<= 10; i++)
            {
                a = i * x;
                Console.WriteLine(i + " x "+ x + " = " + a );
            }
        }
    }
}
