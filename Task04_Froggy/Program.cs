using System;
using System.Linq;

namespace Task03_Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            personalStack<int> datas = new personalStack<int>(Console.ReadLine().Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries).Skip(1).Select(int.Parse).ToList());

            bool isExit = false;

            while (true)
            {
                string[] comand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                        // exit
                if (comand[0].ToUpper() == "END") break;
                // exit


                //comand[0] -> type

                
                switch (comand[0].ToUpper())
                {
                    case "PUSH":
                        // elementToPush -> int.Parse(comand[1]);
                        datas.Push(int.Parse(comand[1]));
                        break;

                    case "POP":
                        if (datas.NumbersOfElements() == 0)
                        {
                            Console.WriteLine("No elements");
                            isExit = true;
                        }
                        else
                        {
                            datas.Pop();
                        }  
                        break;

                    default:
                        break;
                }

            }

            
            if(datas.NumbersOfElements() > 0)
            {
                for (int i = 1; i <= 2; i++)
                {
                    foreach (var item in datas)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            else if(!isExit)
            {
                Console.WriteLine("No elements");
            }
            //Console.WriteLine("Hello World!");
        }
    }
}
