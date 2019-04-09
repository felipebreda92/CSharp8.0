using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsynchronousStream
{
    class Program
    {
        static void Main(string[] args)
        {
            Assynchronous();
        }

        static async Task Assynchronous()
        {
            await foreach (var number in GenerateSequence())
            {
                Console.WriteLine(number);
            }
        }

        static async IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                //await Task.Delay(100);
                yield return i;
            }
        }
    }
}
