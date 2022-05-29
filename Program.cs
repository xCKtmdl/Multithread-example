

var thread1 = new Thread(() => NewClass.MyThread(1,ConsoleColor.Red));
//thread1.Start();

var thread2 = new Thread(() => NewClass.MyThread(2, ConsoleColor.Green));
//thread2.Start();

var thread3 = new Thread(() => NewClass.MyThread(3, ConsoleColor.Blue));
//thread3.Start();


thread1.Start();
Thread.Sleep(50);
thread2.Start();
Thread.Sleep(50);
thread3.Start();



public static class NewClass
{
    
    private static Object myLocl = new object();
    public static void MyThread(int threadNumber, ConsoleColor color)
    {
        for (int i = 0; i < 6; i++)
        {
            lock(myLocl)
            {
                Print(threadNumber, color);
            }
            
        }
    }

    public static void Print(int threadNumber, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        string message = String.Empty;
        switch (color)
        {

            case ConsoleColor.Red:
                message = String.Format("thread: {0}, color: red",threadNumber);
                break;

            case ConsoleColor.Green:
                message = String.Format("thread: {0}, color: green", threadNumber);
                break;
            case ConsoleColor.Blue:
                message = String.Format("thread: {0}, color: blue", threadNumber);
                break;

            default:
                break;
        }
        Console.WriteLine(message);
    }

}