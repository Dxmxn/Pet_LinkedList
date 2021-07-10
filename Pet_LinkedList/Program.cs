using System;

namespace Pet_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Model.LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);

            foreach (var item in list) 
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            list.AppendHead(4);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            list.Delete(3);
            list.Delete(1);
            list.Delete(10);
            foreach (var item in list) 
            {
                Console.Write(item + " ");
            }
            list.InsertAfter(2, 8);
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
