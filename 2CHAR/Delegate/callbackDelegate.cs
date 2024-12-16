using System;

namespace namespace_callback_delegate
{
    public delegate void Notify(string message);

    public class Worker
    {
        public void DoWork(Notify callback)
        {
            Console.WriteLine("Working...");
            System.Threading.Thread.Sleep(1000);
            callback("Task complete");
        }
    }

    public class WorkerTester
    {
        public static void call(string message)
        {
            Console.WriteLine("Callback from the worker");
            Console.WriteLine($"the worker said: {message}");
        }

        public static void main()
        {
            Notify del = WorkerTester.call;
            Worker w = new Worker();
            w.DoWork(del);
        }
    }
}
