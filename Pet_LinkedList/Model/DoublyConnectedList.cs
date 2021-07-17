using System;
using System.Collections;
using System.Collections.Generic;

namespace Pet_LinkedList.Model
{
    class DoublyConnectedList<T> : IEnumerable<T>
    {
        public DoublyConnectedItem<T> Head { get; set; }
        public DoublyConnectedItem<T> Tail { get; set; }
        public int Count { get; set; }

        public DoublyConnectedList(){ }
        public DoublyConnectedList(T data)
        {
            var item = new DoublyConnectedItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }
        public void Add(T data) 
        {
            var item = new DoublyConnectedItem<T>(data);
            if (Count == 0) 
            {
                Head = item;
                Tail = item;
                Count = 1;
                return;
            }
            
            Tail.Next = item;
            item.Previous = Tail;
            Tail = item;
            Count++;
        }
        public void Delete(T data) 
        {
            var current = Head;
            if (Head.Data.Equals(data)) 
            {
                current.Previous.Next = current.Next;
                current.Next.Previous = current.Previous;
                Count--;
                return;
            }
            current = current.Next;
            while (current != null) 
            {
                if (current.Data.Equals(data)) 
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    Count--;
                    return;
                }
                current = current.Next;
            }
        }
        public DoublyConnectedList<T> Reverse() 
        {
            var result = new DoublyConnectedList<T>();

            var current = Tail;
            while (current != null) 
            {
                result.Add(current.Data);
                current = current.Previous;
            }
            return result;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null) 
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }
    }
}
