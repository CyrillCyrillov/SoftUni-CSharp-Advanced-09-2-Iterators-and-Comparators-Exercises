using System;
using System.Linq;

namespace Task04_Froggy
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            Lake frogWay = new Lake(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

            Console.WriteLine(string.Join(", ", frogWay));
            
            
            //Console.WriteLine("Hello World!");
        }
    }
}
