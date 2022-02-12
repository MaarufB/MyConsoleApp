
using System;

namespace myconsole.Challege
{
    public class SortingClass
    {
        public void BubbleSort(int[] arr)
        {

            for(int i=0; i<=arr.Length-1; i++)
            {
                int current = 0;
                for(int j=1; j<arr.Length; j++)
                {
                    current=arr[i];
                    if(arr[i]>arr[j])
                    {
                        arr[i]=arr[j];
                        arr[j]=current;
                    }
                }
            }
            foreach(var item in arr)
            {
                Console.WriteLine($"{item}");
            }
        }        
    }
}