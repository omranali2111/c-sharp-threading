internal class Program
{
    static int value = 10;
    static bool IsLocked=false;
     static async Task Main(string[] args)
    {
        /*
        Thread thread = new Thread(new ThreadStart(doSomething));
       
        thread.Start();
        
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"main thread:{i}");
            Thread.Sleep(10);
        }
       
        thread.Join();//it will wait other threads to fully execute 
        

        Console.WriteLine("Main block");//this will execute at the end 
        
        Thread thread1 = new Thread(incvalue);
        Thread thread2 = new Thread(incvalue);
        thread1.Start();
        thread2.Start();
       // thread1.Join();
        Console.WriteLine(value);
        */

        int result = await add(2, 4);
        Console.WriteLine(result);
        Console.WriteLine("hi");



    }

    public static void doSomething()
    {
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine($" thread:{i}");
            Thread.Sleep(100);
        }

    }

  static void incvalue()

    {
        if (IsLocked)
        {
            IsLocked = true;

            for (int i = 0; i < 10; i++)
            {
                value++;
            }
            IsLocked = false;
        }
    }

    public static async Task<int> add(int a,int b)
    {
        await Task.Delay(1000);
        return a + b;
    }

}