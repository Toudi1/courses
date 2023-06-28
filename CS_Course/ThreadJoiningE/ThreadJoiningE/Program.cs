﻿

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Main Thread started");
        Thread thread1 = new Thread(Thread1Function);
        Thread thread2 = new Thread(Thread2Function);
        thread1.Start();
        thread2.Start();

        if (thread1.Join(1000))
        {
            Console.WriteLine("Thread1Function done");
        }
        else
        {
            Console.WriteLine("Thread1Function wasn't done whitin 1 sec ");
        }
        thread2.Join();
        Console.WriteLine("Thread2Function done");

        for (int i = 0; i<10; i++)
        {
            if (thread1.IsAlive)
            {
                Console.WriteLine("Thread 1 still doing stuff");
                Thread.Sleep(300);
            }
            else
            {
                Console.WriteLine("Thread 1 completed");
            }
        }


        Console.WriteLine("Main Thread ended");
        Console.ReadKey();
    }
    public static void Thread1Function()
    {
        Console.WriteLine("Thread1Function started");
        Thread.Sleep(3000);
        Console.WriteLine("Thread1Function coming back to caller");
    }
    public static void Thread2Function()
    {
        Console.WriteLine("Thread2Function started");
    }
}