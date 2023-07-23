internal class Program
{
    private static void Main(string[] args)
    {
        Thread thread = new Thread(new ThreadStart(doSomething));
        thread.Start();

        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine($"main thread:{i}");
            Thread.Sleep(100);
        }

            
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