using System;

namespace myconsole
{
    public class PrintSquareClass
    {

        
        static void printStarNoSpace(int row)
        {
            for (int i = 1; i <= row * row; i++)
            {
                if (i % row == 0)
                {
                    Console.WriteLine("multiple");
                    Console.WriteLine("*");

                }
                else
                {
                    Console.Write("*");                        
                }
            }
         }

         static void printStartSpace(int row)
         {
             int allRow = row * row; 
             int currentRow = 0;
             for (int i = 1; i <= allRow; i++)
             {
                 if (i % row ==0)
                 {
                    Console.WriteLine($"*");
                    currentRow++;
                 }
                 else 
                 {
                     if (currentRow <=1 || i % row ==0 || currentRow == row)
                     {
                        Console.Write("*");
                     }
                     else Console.Write("*");
                 }
             }
         }
        static void drawSquare(int n)
        {
            Console.WriteLine(new string('*', n)); 

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("*" + new string(' ', n - 2) + "*");
            }

            Console.WriteLine(new string('*', n)); 
        }

    }
}