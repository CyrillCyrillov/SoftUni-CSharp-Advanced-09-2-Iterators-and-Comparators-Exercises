using System;
using System.Linq;
using System.Collections.Generic;

namespace ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {


            string[] createData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();


            ListyIterator<string> dataList = new ListyIterator<string>(createData);

            string nextComand;
            while ((nextComand = Console.ReadLine()) != "END")
            {
                switch (nextComand.ToUpper())
                {
                    case "MOVE":

                        Console.WriteLine(dataList.Move());
                        break;

                    case "PRINT":

                        dataList.Print();
                        break;

                    case "HASNEXT":

                        Console.WriteLine(dataList.HasNext());
                        break;

                    case "PRINTALL":

                        dataList.PrintAll();
                        break;

                    default:
                        break;
                }
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
