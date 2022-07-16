using System.Diagnostics;

namespace ULIDTest;

internal class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new();
        
        stopwatch.Start();
        NulidTest.PrintUlid(100);
        stopwatch.Stop();
        Console.WriteLine("-----");
        Console.WriteLine(stopwatch.ElapsedMilliseconds.ToString());
        Console.WriteLine("-----");

        stopwatch.Restart();
        NulidTest.PrintMonotonicUlid(100);
        stopwatch.Stop();
        Console.WriteLine("-----");
        Console.WriteLine(stopwatch.ElapsedMilliseconds.ToString());
        Console.WriteLine("-----");
    }
}