using System.Threading;

namespace MultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleExample example = new SimpleExample();
            //example.Fun1();
            //example.Fun2();
            Thread cuTh = Thread.CurrentThread;
            
            Thread t = new Thread(new ThreadStart(example.Fun2));


            Thread thread = new Thread(example.Fun1);
            thread.Start();

            Thread thread1 = new Thread(example.Fun2);
            thread1.Start();
        }
    }
}
