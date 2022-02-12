using System;

namespace myconsole.Challege
{
    public class LoopClass
    {

        // Draw a right triangle with asterisk
        public void DrawTriangleAsterisk(int num)
        {
            for(int i=1; i<=num; i++)
            {
                for(int asterisk=1; asterisk<=i; asterisk++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // Draw a right triangle with numbers
        public void DrawTriangleNumber(int num)
        {
            for (int i=1; i<=num; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write($"{j}");
                }
                Console.WriteLine();
            }
        }
    }
}