using System;
using myconsole;
using myconsole.Challege;

namespace myconsole
{
    class Program
    {
        private static Wrapper _wrapper;
        public Program(Wrapper wrapper)
        {
            _wrapper = wrapper;
        }

        static void Main(string[] args)
        {
            int[] arr = {5,3,1,2};
            _wrapper.SortingClass.BubbleSort(arr);
            

        }
    }            
}
