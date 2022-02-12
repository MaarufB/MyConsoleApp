using System;
using System.Collections.Generic;

namespace myconsole
{
    public class NumberClass
    {
        // This function get integer input(more than 1 number) and get the individual number then sum up all the numbers 
        //IEnumerable<int>
        public int GetDigits(int input)
        {
            int currentNumber = input;
            List<int> digits = new List<int>();
           
            // validate the number if not equal 0
            while (currentNumber !=0)
            {
                // This will divide current input and get the modulo only and append or add it to digits list
                digits.Add(currentNumber%10);
                var getModulo = currentNumber% 10;
                // We will update the currentNumber value through dividing the it to 10 so the currentNumber value will get only the integer of currentNumber
                currentNumber = currentNumber/10;
                Console.WriteLine($"The modulo is {getModulo} and the currentNumber is {currentNumber}");
            }

            // We need to reverse the digits list
            digits.Reverse();

            int total = 0;
            foreach(var i in digits)
            {
                total += i;
            }
            Console.WriteLine($"{total}");
            return total;
        }
    }
}