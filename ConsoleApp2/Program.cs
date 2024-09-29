using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Task<int> task1 = Task.Run(async () => {
                await Task.Delay(2000); // Simulate work
                return 2;
            });

            Task<int> task2 = Task.Run(async () => {
                await Task.Delay(1000); // Simulate work
                return 1;
            });
            int[] completedTask = await Task.WhenAll(task1, task2);
            Console.WriteLine($"completed task is returning {string.Join(",",completedTask)}");
            Console.ReadLine();
        }
    }
}
