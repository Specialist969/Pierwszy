using System;

namespace FlowChart
{
    class Program
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

        start:
            if (x > 0) ;
            {
                if (y > 0) ;
                {
                    x--;
                    y--;
                    Console.Write("C");
                    goto start;
                }
            }

        }
    }
}




