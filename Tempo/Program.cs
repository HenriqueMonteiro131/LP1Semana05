using System;
using System.Diagnostics;
using System.Threading;

namespace Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
        
        Stopwatch crono1 = new Stopwatch();
        Stopwatch crono2 = new Stopwatch();

        
        crono1.Start();
        Thread.Sleep(500);
        crono2.Start();
        Thread.Sleep(300);
        crono1.Stop();
        crono2.Stop();

        TimeSpan ts1 = crono1.Elapsed;
        TimeSpan ts2 = crono2.Elapsed;

        string elapsedTime1 = String.Format("{0:F2}", ts1.TotalSeconds);
        Console.WriteLine("RunTime " + elapsedTime1);

        string elapsedTime2 = String.Format("{0:F2}", ts2.TotalSeconds);
        Console.WriteLine("RunTime " + elapsedTime2);
        }
    }
}


/// <summary>
/// 
/// </summary>
///using System;
///using System.Diagnostics;
///using System.Threading;
//class Program
//{
    ////static void Main(string[] args)
    //{
    //    Stopwatch stopWatch = new Stopwatch();
 //       stopWatch.Start();
 //       Thread.Sleep(10000);
//        stopWatch.Stop();
        // Get the elapsed time as a TimeSpan value.
//        TimeSpan ts = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
//        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
//            ts.Hours, ts.Minutes, ts.Seconds,
//            ts.Milliseconds / 10);
//        Console.WriteLine("RunTime " + elapsedTime);
//    }
//}
