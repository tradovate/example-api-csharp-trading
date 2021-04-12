using System;
using System.Diagnostics;

namespace Tradovate
{
    public static class Log
    {
        static bool Enabled = true;
        static private Stopwatch stopwatch = new Stopwatch();
        static public void Write(object message)
        {
            if (Enabled)
            {
                Console.WriteLine($"[+{stopwatch.ElapsedMilliseconds}] {message}");
                stopwatch.Restart();
            }
        }
    }
}