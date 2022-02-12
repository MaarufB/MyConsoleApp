using System;

namespace myconsole
{
    public class SquarePattern
    {
        public void PrintOpenSquare(int row)
        {
            // ****
            // *  *
            // *  *
            // ****
            // define header and footer
            // the starting and ending row doesn't have spacing
            int start = 1;
            int end = row;
            for (int i=1; i<=row; i++)
            {
                if(i==start || i==end)
                {
                    for(int head_foot=1; head_foot<=row; head_foot++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for(int col=1; col<=end; col++)
                    {
                        if(col==start)
                        {
                            Console.Write("*");
                        }
                        else if(col==end)
                            Console.WriteLine("*");
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }

            }
        }
    }
}