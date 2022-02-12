using System;

namespace myconsole
{
    // 1
    // 12
    // 123
    // 1234
    // 12345
    public class PatternClass
    {

        //     *
        //    **
        //   ***
        //  ****
        // *****
        public void PrintTriangleRight(int num)
        {
            for(int i = 1; i<=num; i++)
            {
                //make a space
                for(int space=1; space<=(num-i); space++)
                {
                    Console.Write(" ");
                }
                for(int writer=1; writer<=i; writer++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Done");
        }

        public void PrintTriangleNum(int num)
        {
            for (int i=1; i<=num; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write($"{j}");
                }
                Console.WriteLine("");
            }
        }      

        public void PrintTriangle(int num)
        {
            for (int i=1; i<= num; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write($"*");
                }
                Console.WriteLine("");
            }
        }  

        // The best way to do this is by defining the layer of a pyramid
        public void PrintPyramid(int num)
        {
            int center = (num /2) + 1;
            for (int i=1; i<=num;i++)
            {
                for(int j=1; j<=num-1; j++)
                {
                    Console.Write($" ");
                }
                for(int j=1; j<=2*i-1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }           
        }

        public void PrintPerfectPyramid(int layer)
        {
            int Space, Number;  
            int numberoflayer = layer;
            Console.WriteLine("Print paramid");  
            for (int i = 1; i <= numberoflayer; i++) // Total number of layer for pramid  
            {  
                for (Space = 1; Space <= (numberoflayer - i); Space++) // Loop For Space  
                    Console.Write(" ");  
                for (Number = 1; Number <= i; Number++) //increase the value  
                    Console.Write('*');  
                for (Number = (i - 1); Number >= 1; Number--) //decrease the value  
                    Console.Write('*');  
                Console.WriteLine();  
            }
        }

        public void PrintPerfectPyramidNumber(int layer)
        {
            int space, number;
            for(int i = 1; i <= layer; i++)
            {
                // make a spaces
                for(space = 1; space <= (layer - 1); space++)
                {
                    Console.Write($" ");
                }
                for (number=1; number <= i; number++)
                {
                    Console.Write($"{number}");
                }
                for(number = ( i - 1 ); number >= 1; number--)
                {
                    Console.Write($"{number}");
                }
                Console.WriteLine();
            }
        }

    }
}