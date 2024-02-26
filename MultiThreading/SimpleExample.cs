using System;
using System.Threading;

namespace MultiThreading
{
    internal class SimpleExample
    {
        public void Fun1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Fun 1 " +i);
                Thread.Sleep(1000);
            }
            
        }
        public void Fun2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Fun 2 " +i);
                Thread.Sleep(100);
            }
        }
    }
}
