using Pet_LinkedList.Model;
using System;

namespace Pet_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList
            /*
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
            */
            #endregion
            #region DoublyConnectedList
            var doublyConnectedList = new DoublyConnectedList<int>();

            doublyConnectedList.Add(1);
            doublyConnectedList.Add(2);
            doublyConnectedList.Add(3);
            doublyConnectedList.Add(4);
            doublyConnectedList.Add(5);
            doublyConnectedList.Add(6);

            foreach (var item in doublyConnectedList) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            doublyConnectedList.Delete(3);
            doublyConnectedList.Delete(7);
            doublyConnectedList.Delete(-5);
            foreach (var item in doublyConnectedList)
            {
                Console.WriteLine(item);
            }
            var reverse = doublyConnectedList.Reverse();
            Console.WriteLine();
            foreach (var item in reverse)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            #endregion
        }
    }
}
