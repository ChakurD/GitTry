namespace Lesson33HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mutex
            //int x = 0;
            //Mutex mutexObj = new();

            //for (int i = 1; i < 6; i++)
            //{
            //    Thread myThread = new(Print);
            //    myThread.Name = $"Поток {i}";
            //    myThread.Start();
            //}

            //void Print()
            //{
            //    mutexObj.WaitOne();     
            //    x = 1;
            //    for (int i = 1; i < 6; i++)
            //    {
            //        Console.WriteLine($"{Thread.CurrentThread.Name}:  {x}");
            //        x++;
            //        Thread.Sleep(100);
            //    }
            //    mutexObj.ReleaseMutex();    
            //}

            //-------------------------------------------------------

            //Monitor
            //int x = 0;
            //object locker = new();  // объект-заглушка
            //                        // запускаем пять потоков
            //for (int i = 1; i < 6; i++)
            //{
            //    Thread myThread = new(Print);
            //    myThread.Name = $"Поток {i}";
            //    myThread.Start();
            //}

            //void Print()
            //{
            //    bool acquiredLock = false;
            //    try
            //    {
            //        Monitor.Enter(locker, ref acquiredLock);
            //        x = 1;
            //        for (int i = 1; i < 6; i++)
            //        {
            //            Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
            //            x++;
            //            Thread.Sleep(100);
            //        }
            //    }
            //    finally
            //    {
            //        if (acquiredLock) Monitor.Exit(locker);
            //    }
            //}

            // semafor

            //-------------------------------------------------------

            //for (int i = 1; i < 6; i++)
            //{
            //    var myThread = new Thread(Read);
            //    myThread.Name = $"Читатель {i}";
            //    myThread.Start();
            //}
           
            //void Read()
            //{
            //    var semaphore = new Semaphore(3, 3);
            //    int count = 3;
            //    while (count > 0)
            //    {
            //        semaphore.WaitOne();  

            //        Console.WriteLine($"{Thread.CurrentThread.Name} входит в библиотеку");

            //        Console.WriteLine($"{Thread.CurrentThread.Name} читает");
            //        Thread.Sleep(1000);

            //        Console.WriteLine($"{Thread.CurrentThread.Name} покидает библиотеку");

            //        semaphore.Release();  

            //        count--;
            //        Thread.Sleep(1000);
            //    }
            //}
        }
    }
    
}