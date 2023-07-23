internal class Program
{
    private static void Main(string[] args)
    {
        Thread thread = new Thread(new ThreadStart(doSomething));
        Console.WriteLine("ThreadState: {0}", thread.ThreadState);
        thread.Start();
        Console.WriteLine("ThreadState: {0}", thread.ThreadState);

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"main thread:{i}");
            Thread.Sleep(10);
        }
        Console.WriteLine("ThreadState: {0}", thread.ThreadState);
        thread.Join();//it will wait other threads to fully execute 
        Console.WriteLine("ThreadState: {0}", thread.ThreadState);

        Console.WriteLine("Main block");//this will execute at the end 
            
    }

    public static void doSomething()
    {
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine($"worker thread:{i}");
            Thread.Sleep(100);
        }

    }
}