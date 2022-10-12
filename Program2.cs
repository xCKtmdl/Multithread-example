
var myTask = new MyClass();

await Task.Run(() => myTask.MyAsync(1, ConsoleColor.Red));

await Task.Run(() => myTask.MyAsync(2, ConsoleColor.Green));

await Task.Run(() => myTask.MyAsync(3, ConsoleColor.Blue));


//Task.Run(() => myTask.MyAsync(1, ConsoleColor.Red));
//Task.Run(() => myTask.MyAsync(2, ConsoleColor.Green));
//Task.Run(() => myTask.MyAsync(3, ConsoleColor.Blue));

//Thread.Sleep(10000);
//await Task.Delay(1000);






public class MyClass
{
    private static Object myLocl = new object();
    public async Task MyAsync(int threadNumber, ConsoleColor color)
    {
        for (int i = 0; i < 1; i++)
        {
            // lock(myLocl)
            //  {
            Print(threadNumber, color);
            // }

        }
    }


    public static void Print(int threadNumber, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        string message = String.Empty;
        switch (color)
        {

            case ConsoleColor.Red:
                message = String.Format("thread: {0}, color: red", threadNumber);
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